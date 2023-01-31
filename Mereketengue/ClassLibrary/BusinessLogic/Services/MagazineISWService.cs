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

        public Entities.Magazine getMagazine() { return magazine; }
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

            User ChiefEditor = AddUser("1234", "MC", "Penades", false, true, "documentos", "mpenades@gmail.com", "mpenades", "1234");

            Magazine.Entities.Magazine m1 = AddMagazine("Revista Universitària UUPPVV", ChiefEditor);

            setMagazine(m1);

            User u1 = AddUser("2345", "Ana", "Nunez", false, true, "emergencias", "anunez@gmail.com", "anunez", "1234");

            User u2 = AddUser("3456", "Jose", "Garcia", false, true, "pruebas", "jgarcia@gmail.com", "jgarcia", "1234");

            User u3 = AddUser("4567", "Juan", "Perez", false, true, "software", "jperez@gmail.com", "jperez", "1234");

            User jav = AddUser("5000", "Javi", "Diéguez", false, true, "pan", "javi@gmail.com", "javi", "1234");

            User car = AddUser("5001", "Ángel", "Carmona", false, true, "lentejas", "carmona@gmail.com", "angel", "1234");

            User dan = AddUser("5002", "Dani", "suchard", false, true, "ensalada", "dani@gmail.com", "dani", "1234");

            User pab = AddUser("5003", "Pablo", "covid", false, true, "brocheta", "cabo@gmail.com", "pablo", "1234");

            Area Juegos = AddArea("Juegos", jav, m1);

            Area Coches = AddArea("Coches", car, m1);

            Area Comida = AddArea("Comida", pab, m1);
            
            Area Deportes = AddArea("Deportes", dan, m1);
            
            Paper p1 = AddPaper("Subnautica", DateTime.Now, Juegos, car);
            p1.addCoauthor(u2);
            p1.addCoauthor(u1);
            Paper p2 = AddPaper("Ark", DateTime.Now, Juegos, jav);
            Juegos.AddToPublPendPapers(p2);
            Paper p3 = AddPaper("Portal", DateTime.Now, Juegos, pab);
            p3.addCoauthor(u3);
            Paper p4 = AddPaper("Ferrari", DateTime.Now, Coches, car);
            //Coches.addToPapers(p4);
            Coches.AddToEvalPendPapers(p4);
            Paper p5 = AddPaper("BMW", DateTime.Now, Coches, jav);
            p5.addCoauthor(u1);
            p5.addCoauthor(u2);
            Paper p6 = AddPaper("Kia", DateTime.Now, Coches, dan);
            Coches.AddToPublPendPapers(p6);
            Paper p7 = AddPaper("Fiat", DateTime.Now, Coches, pab);
            p7.addCoauthor(u1);
            p7.addCoauthor(u3);
            Paper p8 = AddPaper("burrito", DateTime.Now, Comida, dan);
            Comida.addToPapers(p8);
            Comida.AddToEvalPendPapers(p8);
            Paper p9 = AddPaper("patatas", DateTime.Now, Comida, pab);
            p9.addCoauthor(u1);
            p9.addCoauthor(u2);
            p9.addCoauthor(u3);
            Paper p10 = AddPaper("sopa", DateTime.Now, Comida, pab);
            Comida.AddToPublPendPapers(p10);
            Paper p11 = AddPaper("macarrones", DateTime.Now, Comida, car);
            Paper p12 = AddPaper("furbo", DateTime.Now, Deportes, car);
            Deportes.addToPapers(p12);
            Deportes.AddToEvalPendPapers(p12);
            Paper p13 = AddPaper("voley", DateTime.Now, Deportes, jav);
            p13.addCoauthor(u1);
            p13.addCoauthor(u2);
            p13.addCoauthor(u3);
            Paper p14 = AddPaper("Esports", DateTime.Now, Deportes, dan);
            p14.addCoauthor(u2);
            p14.addCoauthor(u3);
            Deportes.AddToPublPendPapers(p14);
            Paper p15 = AddPaper("Jeep", DateTime.Now, Coches, jav);
            Coches.AddToPublPendPapers(p15);
            Paper p16 = AddPaper("tarta", DateTime.Now, Comida, jav);
            Comida.AddToPublPendPapers(p16);
            Paper p17 = AddPaper("Minecraft", DateTime.Now, Juegos, dan);
            Juegos.AddToPublPendPapers(p17);
            Paper p18 = AddPaper("Basket", DateTime.Now, Deportes, pab);
            Deportes.AddToPublPendPapers(p18);

            //crear Issues
            DateTime date1 = new DateTime(2024, 4, 19);
            DateTime date2 = new DateTime(2024, 3, 11);
            Issue i0 = AddIssue(0, m1,10,50,date1);
            i0.addToPublishedPapers(p3);
            i0.addToPublishedPapers(p5);
            i0.addToPublishedPapers(p7);
            p3.Issue = i0;
            p5.Issue = i0;
            p7.Issue = i0;
            Issue i1 = AddIssue(1, m1, 10, 5,date2);
            i1.addToPublishedPapers(p9);
            i1.addToPublishedPapers(p11);
            p9.Issue = i1;
            p11.Issue = i1;
            Issue i2 = AddIssue(2, m1, 10, 5, DateTime.Now);
            i2.addToPublishedPapers(p13);
            i2.addToPublishedPapers(p1);
            p13.Issue = i2;
            p1.Issue =  i2;
            Commit();

            /*Evaluation e1 = AddEvaluation(true, "Evaluation 1", DateTime.Now);

            p6.PublicationPendingArea = Juegos;

            Juegos.AddToPublPendPapers(p1);

            Evaluation e2 = AddEvaluation(true, "Evaluation 2", DateTime.Now);

            p2.EvaluationPendingArea = a2;*/
        }

        public User getLoggedUser() { return LoggedUser; }
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
        public bool SignUp(string id, string name, string surname, bool alerted, bool suscribed, string areasOfInterest, string email, string login, string password)
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
                AddUser(id, name, surname, alerted, suscribed, areasOfInterest, email, login, password);
                return true;
            }
            return false;
        }

        public User AddUser(string id, string name, string surname, bool alerted, bool suscribed, string areasOfInterest, string email, string login, string password)
        {
            User user = new User(id, name, surname, alerted, suscribed, areasOfInterest, email, login, password);
            dal.Insert<User>(user);
            Commit();
            return user;
        }
        
        public User SearchUser(String id)
        {
            foreach (User u in dal.GetAll<User>())
            {
                if (u.comprobarId(id)) { return u; }

            }
            throw new ServiceException("No existe User");
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
            if (area.Editor.Equals(LoggedUser)|| magazine.ChiefEditor.Equals(LoggedUser)) //solo puede hacerlo el AreaEditor
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
            else { throw new ServiceException("You are not allowed to Evaluate this Paper, only the Area's editor can do it."); }
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

        public Paper SearchPaper(String name, Area area)
        {
            foreach (Paper p in area.Papers)
            {
                if (p.comprobarTitle(name)) { return p; }

            }
            throw new ServiceException("No existe paper");
        }
        public Paper AddPaper(string title, DateTime uploadDate, Area belongingArea, User responsible)
        {
            Paper paper = new Paper(title, uploadDate, belongingArea, responsible);
            dal.Insert<Paper>(paper);
            //belongingArea.addToPapers(paper);
            //belongingArea.AddToEvalPendPapers(paper);
            Commit();
            return paper;
        }

        #endregion


        #region Issue
        public Issue searchIssue(int number)
        {
            foreach (Issue i in magazine.Issues)
            {
                if (i.comprobarNumberIssue(number)) { return i; }
            }
            throw new ServiceException("Error: Area  dont Exist");
        }
        public Issue BuildIssue(int number, DateTime publicationDate, ICollection<Paper> listaPapersAux, float price, float discount)
        {
            if (LoggedUser.Equals(magazine.ChiefEditor)) //solo si es el chiefEditor
            {
                //Issue issue = magazine.gMaxNumberIssue();
                //if (!issue.IssuePendientePub((DateTime)issue.PublicationDate))//cambiar
                Issue issue = CreateIssue(publicationDate,number, magazine, listaPapersAux, discount, price);
                foreach (Paper p in listaPapersAux)
                {
                    Area aux = p.BelongingArea;
                    if (aux.containsPaperPendPub(p)) { aux.DeleteFromPublPendPapers(p); }
                    Commit();
                }
                //else //ya existe, edit
                //DateTime fechaPubli = (DateTime)issue.PublicationDate;

                return issue;
            }
            else { throw new ServiceException("You are not allowed to create Issues"); }
        
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

        

        
        public ICollection<Paper> getPendingPublicationPapers(Area area) {
            return area.PublicationPending;
        }
        public void eliminarPublishedpapers(ICollection<Paper> papers)
        {
            foreach (Paper p in papers)
            {
                Area aux = p.BelongingArea;
                aux.AddToPublPendPapers(p);
            }
            Commit();
        }
        public void EditIssue(Issue issue, ICollection<Paper> publishedPapers, DateTime pubdate, float discount, float price) {

            issue.clearPublishedpapers();
            issue.PublishedPapers = publishedPapers;
            issue.Price = price;
            issue.Discount = discount;
            issue.PublicationDate = pubdate;
            foreach(Paper p2 in publishedPapers)
            {
                Area aux2 = p2.BelongingArea;
                if (aux2.containsPaperPendPub(p2)) { aux2.DeleteFromPublPendPapers(p2); }
            }
            Commit();
        }

        public Issue CreateIssue(DateTime fecha, int number, Magazine.Entities.Magazine magazine, ICollection<Paper> listaPapersAux, float discount, float price)
        {
            Issue issue = new Issue(number, magazine,discount,price);
            issue.PublicationDate = fecha;

            issue.PublishedPapers = listaPapersAux;
            magazine.addToIssues(issue);
            dal.Insert<Issue>(issue);
            Commit();
            return issue;
        }
        public Issue AddIssue(int number, Magazine.Entities.Magazine magazine, float discount, float price, DateTime pubtime)
        {
            Issue issue = new Issue(number, magazine, discount, price);
            issue.PublicationDate = pubtime;
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

        public Area SearchArea(String name)
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
                }
                if (!encontrado)
                {
                    if (paper.gCoAuthorsCount() < 4)
                    {   //comprobar si exixte persona
                        Person person = new Person(id, name, surname);
                        paper.addCoauthor(person);
                        person.AñadiralPaper(paper);
                        dal.Insert<Person>(person);
                        Commit();
                        return person;
                    }
                    else { throw new ServiceException("There is already 4 Coauthors for this paper"); }
                }
            }
            throw new ServiceException("You are not allowed to add Coauthors to this paper, only the paper's responsible can do it");
        }

        public void deleteCoauthor(Person person, Paper paper) // por si acaso
        {
            if (paper != null && person != null)
            {
                if (paper.gCoAuthorsCount() > 0)
                {
                    paper.deleteCoauthor(person);
                    person.EliminarDelPaper(paper);
                    Commit();
                }
            }
            else { throw new ServiceException("There is no person selected"); }
        }

        public Person SearchPerson(String id)
        {
            foreach (Person p in dal.GetAll<Person>())
            {
                if (p.comprobarId(id)) { return p; }

            }
            throw new ServiceException("No existe person");
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
