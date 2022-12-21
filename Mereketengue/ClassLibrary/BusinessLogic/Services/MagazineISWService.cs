using Magazine.Entities;
using Magazine.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private ICollection<Paper> listaPapers;

        public void setMagazine(Entities.Magazine magazine) { 
            this.magazine = magazine;
        }
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

            User ChiefEditor = AddUser("1234", "MC", "Penades", false, "documentos", "mpenades@gmail.com", "mpenades", "1234");

            Magazine.Entities.Magazine m1 = AddMagazine("Revista Universitària UUPPVV", ChiefEditor);

            setMagazine(m1);

            User u2 = AddUser("2345", "Ana", "Nunez", false, "emergencias", "anunez@gmail.com", "anunez", "1234");

            Area a1 = AddArea("Area A1", u2, m1);

            User u3 = AddUser("3456", "Jose", "Garcia", false, "pruebas", "jgarcia@gmail.com", "jgarcia", "1234");

            Area a2 = AddArea("Area 2", u3, m1);

            User u4 = AddUser("4567", "Juan", "Perez", false, "software", "jperez@gmail.com", "jperez", "1234");

            Paper p1 = AddPaper("titulillo", DateTime.Now, a2, u2);
            Issue i1 = CreateIssue(1, m1, listaPapers);

            Evaluation e1 = AddEvaluation(true, "Evaluation 1", DateTime.Now);

            p1.EvaluationPendingArea = a2;

            a2.AddToPublPendPapers(p1);

            Paper p2 = AddPaper("Paper 2", DateTime.Now, a2, u2);

            Evaluation e2 = AddEvaluation(true, "Evaluation 2", DateTime.Now);

            p2.EvaluationPendingArea = a2;

            a2.AddToPublPendPapers(p2);
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
            return false;
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
                    //throw new ServiceException("Error: You are already registered, go to Log in page");
                    return false;
                }
                if (u.comprobarLogin(login))
                {
                    encontrado = true;
                    //throw new ServiceException("Error: That login is already used, try again.");
                    return false;
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
        public Paper EnviarPaper(Area area, string Title) // se usa en paper submision
        {
            foreach (Paper p in area.Papers) {
                if (p.comprobarTitle(Title)) 
                {
                    throw new ServiceException("There is already a paper with the same Title in this area");
                }
            }
            Paper paper = new Paper(Title, DateTime.Now, area, LoggedUser);
            paper.EvaluationPendingArea = area;
            area.addToPapers(paper);
            area.AddToEvalPendPapers(paper);
            dal.Insert<Paper>(paper);
            Commit();
            return paper;
        }

        public void EvaluatePaper(Area area, Paper paper, Boolean decision, string comentarios)
        {
            if (area.Editor.Equals(LoggedUser)) //solo puede hacerlo el AreaEditor
            {
                Evaluation evaluacion = AddEvaluation(decision, comentarios, DateTime.Now);
                paper.Evaluation = evaluacion;

                if (decision)
                {
                    area.AddToPublPendPapers(paper);
                    paper.PublicationPendingArea = area;
                    area.DeleteFromEvalPendPapers(paper);
                    Commit();

                }
                else
                {
                    area.DeleteFromEvalPendPapers(paper);
                    paper.EvaluationPendingArea = null;
                    Commit();
                }
            }
            throw new ServiceException("You are not allowed to Evaluate this Paper, only the Area's editor can do it.");
        }

        public ICollection<Paper> ListarPapersEvPending(Area area)
        {
            if (LoggedUser.Equals(magazine.ChiefEditor)) //solo si es el chiefEditor
            {
                return area.EvaluationPending; //devuelve pendientes de evaluación
            }
            throw new ServiceException("You are not allowed to list Papers, only the ChiefEditor can do it.");

        }
        public ICollection<Paper> ListarPapersPublPending(Area area)
        {
            if (LoggedUser.Equals(magazine.ChiefEditor)) //solo si es el chiefEditor
            {
                return area.PublicationPending; //devuelve pendientes de publicación
            }
            throw new ServiceException("You are not allowed to list Papers, only the ChiefEditor can do it.");

        }
        public ICollection<Paper> ListarPublishedPapers(Area area)
        {
            if (LoggedUser.Equals(magazine.ChiefEditor)) //solo si es el chiefEditor
            {
                ICollection<Paper> papers = area.Papers;
                ICollection<Paper> Evpendingpapers = area.EvaluationPending;
                ICollection<Paper> PublPendingPapers = area.EvaluationPending;
                foreach(Paper paper in papers) //me quedo con los que están publicados o rechazados
                {
                    if(Evpendingpapers.Contains(paper) || PublPendingPapers.Contains(paper)) { papers.Remove(paper);}
                    if (!paper.gEvaluationDecision()) { papers.Remove(paper); } //elimino los rechazados
                } 
                return papers;//devuelve aceptados y publicados 
            }
            throw new ServiceException("You are not allowed to list Papers, only the ChiefEditor can do it.");

        }
        public ICollection<Paper> ListarPapersRechazados(Area area) 
        {
            if (LoggedUser.Equals(magazine.ChiefEditor)) //solo si es el chiefEditor
            {
                ICollection<Paper> papers = area.Papers;
                ICollection<Paper> Evpendingpapers = area.EvaluationPending;
                ICollection<Paper> PublPendingPapers = area.EvaluationPending;
                foreach (Paper paper in papers) //me quedo con los que están publicados o rechazados
                {
                    if (Evpendingpapers.Contains(paper) || PublPendingPapers.Contains(paper)) { papers.Remove(paper); }
                    if (paper.gEvaluationDecision()) { papers.Remove(paper); } //elimino los publicados
                }
                return papers; //devuelve rechazados
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

        public Boolean BuildIssue(DateTime publicationDate, ICollection<Paper> listaPapersAux)
        {
            if (LoggedUser.Equals(magazine.ChiefEditor)) //solo si es el chiefEditor
            {
                Issue issue = magazine.gMaxNumberIssue();

                if (!issue.IssuePendientePub((DateTime)issue.PublicationDate))//cambiar
                {
                    CreateIssue(issue.Number + 1, magazine, listaPapersAux);
                }
                else //ya existe, edit
                {
                    DateTime fechaPubli = (DateTime)issue.PublicationDate;

                    EditIssue(issue, listaPapersAux, fechaPubli, issue.Number);
                }
                return true;
            }
            else { return false; }
        
        }
        public ICollection<Issue> getAllIssues() {
            return magazine.Issues;
        }
        public Issue getLastIssue() {
            return magazine.gMaxNumberIssue();

        }

        public Boolean pendingPublication(Issue issue) {
            Boolean res = false;
            if ((DateTime)issue.PublicationDate >= DateTime.Now) {
                res = true;
            }
            return res;
        }

        

        public Paper gPaper(String name, Area area) {
            foreach (Paper p in area.Papers) {
                if (p.comprobarTitle(name)) { return p;  }
                
            }
            throw new ServiceException("No existe paper");
        }
        public ICollection<Paper> getPendingPublicationPapers(Area area) {
            return area.PublicationPending;
        }

        public void EditIssue(Issue issue, ICollection<Paper> publishedPapers, DateTime fechaPubli, int number) {
            issue.PublishedPapers = publishedPapers;
            issue.Number = number;
            issue.PublicationDate = fechaPubli;
            issue.PublishedPapers = listaPapers;
            Commit();
        }

        public Issue CreateIssue(int number, Magazine.Entities.Magazine magazine, ICollection<Paper> listaPapersAux)
        {
            Issue issue = new Issue(number, magazine);
            issue.PublicationDate = DateTime.Now;
            issue.PublishedPapers = listaPapersAux;
            magazine.addToIssues(issue);
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

        public Area gArea(String name)
        {
            foreach (Area a in magazine.Areas)
            {
                if (a.comprobarName(name)) { return a; }
            }
            throw new ServiceException("Error: Area  dont Exist");

        }

        public ICollection<Paper> getPendingEvaluationPapers(Area area) {
            return area.EvaluationPending;
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
            ICollection<Area> list = magazine.Areas;
            return list;
        }

        #endregion

        #region Person

        public Person AddPerson(string id, string name, string surname) //para inicializar la base de datos
        {
            Person person = new Person(id,name,surname);
            dal.Insert<Person>(person);
            Commit();
            return person;
        }

        public Person addCoauthor(string id, string name, string surname, Paper paper) //se usa en paper submision
        {
            if (LoggedUser.Equals(paper.Responsible))
            {
                Boolean encontrado = false;
                foreach (Person p in dal.GetAll<Person>())
                {
                    if (p.comprobarId(id))
                    {
                        encontrado = true;
                        throw new ServiceException("Error: There is already a Person with that id");
                    }
                    if (!encontrado)
                    {
                        if (paper.gCoAuthorsCount() < 4)
                        {   //comprobar si exixte persona
                            Person person = new Person(id, name, surname);
                            paper.addCoauthor(person);
                            person.AñadiralPaper(paper);
                            dal.Insert<Person>(person);
                            return person;
                        }
                        else { throw new ServiceException("There is already 4 Coauthors for this paper"); }
                    }
                }
            }
            throw new ServiceException("You are not allowed to add Coauthors to this paper, only the paper's responsible can do it");
        }

        public void deleteCoauthor(Person person, Paper paper) // por si acaso
        {
            if (paper.gCoAuthorsCount()> 0)
            {
                paper.deleteCoauthor(person);
                person.EliminarDelPaper(paper);
                Commit();
            }
        }
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
        public User gLoggedUser() { return LoggedUser; }
    }

}
