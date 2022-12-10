using Magazine.Entities;
using Magazine.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Magazine.Services
{
    public class MagazineISWService : IMagazineISWService
    {
        // DAL 
        private readonly IDAL dal;
        private User LoggedUser;
        private Entities.Magazine magazine;
        private int number;

        public MagazineISWService(IDAL dal)
        {
            this.dal = dal;

        }

        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }

        public void DBInitialization()
        {
            RemoveAllData();

            User u1 = AddUser("1234", "MC", "Penades", false, "documentos", "mpenades@gmail.com", "mpenades", "1234");

            Magazine.Entities.Magazine m1 = AddMagazine("Revista Universitària UUPPVV", u1);

            User u2 = AddUser("2345", "Ana", "Nunez", false, "emergencias", "anunez@gmail.com", "anunez", "1234");

            Area a1 = AddArea("Area A1", u2, m1);

            User u3 = AddUser("3456", "Jose", "Garcia", false, "pruebas", "jgarcia@gmail.com", "jgarcia", "1234");

            Area a2 = AddArea("Area 2", u3, m1);

            User u4 = AddUser("4567", "Juan", "Perez", false, "software", "jperez@gmail.com", "jperez", "1234");

            Issue i1 = AddIssue(1, m1);
        }

        #region User
        /// <summary>   Performs login validation and logs in </summary>
        /// <param>     <c>login</c> is the user login name 
        /// </param>
        /// <param>     <c>password</c> is the user password for login. 
        /// </param>
        /// <returns>   Any required ServiceExceptions
        ///             userId if login succeeds
        /// </returns>
        public bool Login(string login, string password)
        {
            foreach (User u in dal.GetAll<User>())
            {
                if (u.comprobarLogin(login) && u.comprobarPassword(password))
                {
                    LoggedUser = u;
                    return true;
                }
            }
            throw new ServiceException("Login or Password are not correct.");
        }

        /// <summary>   Performs a log out operation </summary>

        /// <summary>   Performs User info validation and registers a new user. </summary>
        /// <param>     <c>id</c> is the user identification. 
        /// </param>
        /// <param>     <c>name</c> is the user first name. 
        /// </param>
        /// <param>     <c>surname</c> is the user last name. 
        /// </param>
        /// <param>     <c>alerted</c> is the user willingness to be alerted. 
        /// </param>
        /// <param>     <c>areasOfInterest</c> text describing the areas the user is interested in. 
        /// </param>
        /// <param>     <c>email</c> user email address. 
        /// </param>
        /// <param>     <c>login</c> is the user login name 
        /// </param>
        /// <param>     <c>password</c> is the user password for login. 
        /// </param>
        /// <returns>   Any required ServiceExceptions
        /// </returns>
        public bool SignUp(string id, string name, string surname, bool alerted, string areasOfInterest, string email, string login, string password)
        {
            Boolean encontrado = false;
            foreach (User u in dal.GetAll<User>())
            {
                if (u.comprobarId(id))
                {
                    encontrado = true;
                    throw new ServiceException("Error: You are already registered, go to Log in page");
                }
                if (u.comprobarLogin(login))
                {
                    encontrado = true;
                    throw new ServiceException("Error: That login is already used, try again.");
                }
            }
            if (!encontrado)
            {
                AddUser(id, name, surname, alerted, areasOfInterest, email, login, password);
                return true;
            }
            return false;
        }

        public User AddUser(string id, string name, string surname, bool alerted, string areasOfInterest, string email, string login, string password)
        {
            User user = new User(id, name, surname, alerted, areasOfInterest, email, login, password);
            dal.Insert<User>(user);
            Commit();
            return user;
        }
        #endregion

        #region Paper
        public Paper EnviarPaper(Area area, string Title, List<string> lista) // se usa en paper submision
        {
            Paper paper = AddPaper(Title, DateTime.Now, area, LoggedUser ); 
            paper.setEvaluationPendingArea(area);
            area.addToPapers(paper);
            return paper;
        }

        public ICollection<Paper> getAllNoEvPapers(Area area) // se usa en Evaluate paper
        {
            return area.EvaluationPendingPapers();
        }

        public void EvaluatePaper(Area area, Paper paper, Boolean decision, string comentarios)
        {
            if (area.gEditor().Equals(LoggedUser)) //solo puede hacerlo el AreaEditor
            {
                Evaluation evaluacion = AddEvaluation(decision, comentarios, DateTime.Now);
                Area areaPaper = paper.getPaperArea();
                paper.setEvaluation(evaluacion);

                if (decision)
                {
                    areaPaper.AddToPublicationPendingPapers(paper);
                    paper.setPublicationPendingArea(areaPaper);
                    areaPaper.DeleteFromEvaluatePendingPaper(paper);
                }
                else
                {
                    areaPaper.DeleteFromEvaluatePendingPaper(paper);
                    paper.removeEvaluationPendingArea();
                }
            }
            throw new ServiceException("You are not allowed to Evaluate this Paper, only the Area's editor can do it.");
        }

        public void ListarPaper(string filtro)  // intento 1 dani
        {
            Boolean existe = false;
            ICollection<Paper> ListaFiltrada;
            if (filtro.Equals(""))
            {
            }
            else
            {
                foreach (Issue i in dal.GetAll<Issue>())
                {
                    if (i.Id.Equals(filtro))
                    {
                        ListaFiltrada.Add(i);
                        existe = true;
                    }
                }
                if (existe) { return ListaFiltrada; }
                else { throw new ServiceException("No se encueentra un Issue con este number."); }
            }
        }

        public ICollection<Paper> ListarPaper(Area area) // intento 2
        {
            if (LoggedUser.Equals(magazine.gChiefEditor())) //solo si es el chiefEditor
            { 
                ICollection<Paper> listaPapers = area.gPapers();
                List<string> listaStates = new List<string>(listaPapers.Count);
                //pregunta como funcionan las tablas, como crear lista con los atributos que yo quiera de un objeto y con otros elementos añadidos
                int cont = 0;
                foreach (Paper p in listaPapers)
                {
                    cont++;
                    if (p.hasEvaluation())
                    {
                        if (p.gEvaluationDecision())
                        {
                            listaStates[cont] = "accepted";
                        }
                        else
                        {
                            listaStates[cont] = "rejected";
                        }
                    }
                    else
                    {
                        listaStates[cont] = "Evaluation Pending";
                    }

                }
                return listaPapers;
            }
            throw new ServiceException("You are not allowed to list Papers, only the ChiefEditor can do it.");

        }

        public Paper AddPaper(string title, DateTime uploadDate, Area belongingArea, User responsible)
        {
            Paper paper = new Paper(title, uploadDate, belongingArea, responsible);
            dal.Insert<Paper>(paper);
            Commit();
            return paper;
        }

        #endregion


        #region Issue

        public void setNumberIssue() 
        {
            if (magazine.gIssues().Count == 0) { number = 1; }
            else { number = magazine.gIssues().Count + 1; }
        }

        Issue BuildIssue(int id, int number)
        {
            if (LoggedUser.Equals(magazine.gChiefEditor())) //solo si es el chiefEditor
            { 
                Boolean trobada = false;
                Issue resp;
                foreach (Issue i in dal.GetAll<Issue>())
                {
                    if (i.Number == number) { trobada = true; }
                }
                if (trobada == true)
                {
                    resp = dal.GetById<Issue>(number);
                }
                else
                {
                    Area areaSelec = dal.GetById<Area>(id);
                    foreach (Paper p in areaSelec.Papers)
                    {
                        areaSelec.PublicationPending.Add(p);
                        areaSelec.EvaluationPending.Add(p);
                    }
                }
                return resp;
            }
            throw new ServiceException("You are not allowed to list Papers, only the ChiefEditor can do it.");
        
        }

        public Issue AddIssue(int number, Magazine.Entities.Magazine magazine)
        {
            Issue issue = new Issue(number, magazine);
            issue.setPublicationDate(DateTime.Now); 
            dal.Insert<Issue>(issue);
            Commit();
            return issue;
        }

        #endregion

        #region Area
        public Area AddArea(string name, User editor, Entities.Magazine magazine)
        {
            Area area = new Area(name, editor, magazine);
            dal.Insert<Area>(area);
            Commit();
            return area;
        }

        #endregion

        #region Magazine
        public Magazine.Entities.Magazine AddMagazine(string name, User chiefEditorId)
        {
            Entities.Magazine magazine = new Entities.Magazine(name, chiefEditorId);
            dal.Insert<Entities.Magazine>(magazine);
            Commit();
            return magazine;
        }

        public ICollection<Area> listAreas() // se usa en paper submision y en Evaluatepaper, por ahora
        {
            ICollection<Area> list = magazine.gAreas();
            return list;
        }



        #endregion

        #region Person

        public Person AddPerson(string id, string name, string surname)
        {
            Person person = new Person(id,name,surname);
            dal.Insert<Person>(person);
            Commit();
            return person;
        }

        public Person addCoauthor(string id, string name, string surname, Paper paper) //se usa en paper submision
        {
            if (LoggedUser.Equals(paper.gResponsible()))
            {
                if (paper.gCoAuthors().Count < 4)
                {
                    //como ponemos el id de una person? lo hace el entityframework?
                    Person person = AddPerson(id, name, surname);
                    paper.addCoauthor(person);
                    person.AñadiralPaper(paper);
                    return person;
                }
                else { throw new ServiceException("There is already 4 Coauthors for this paper"); }
            }
            throw new ServiceException("You are not allowed to add Coauthors to this paper, only the paper's responsible can do it");
        }

        public void deleteCoauthor(Person person, Paper paper)
        {
            if (paper.gCoAuthors().Count > 0)
            {
                paper.deleteCoauthor(person);
                person.EliminarDelPaper(paper);
            }
        }// por si acaso
        #endregion

        #region Evaluation
        public Evaluation AddEvaluation(bool accepted,String comentarios, DateTime time)
        {
            Evaluation evaluation = new Evaluation(accepted,comentarios,time);
            dal.Insert<Evaluation>(evaluation);
            Commit();
            return evaluation;
        }
        #endregion
    }
}
