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

namespace Magazine.Services
{
    public class MagazineISWService : IMagazineISWService
    {
        // DAL 
        private readonly IDAL dal;
        private User LoggedUser;
        private Entities.Magazine magazine;

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

            AddArea("Area A1", u2, m1);

            User u3 = AddUser("3456", "Jose", "Garcia", false, "pruebas", "jgarcia@gmail.com", "jgarcia", "1234");

            Area a2 = AddArea("Area 2", u3, m1);

            User u4 = AddUser("4567", "Juan", "Perez", false, "software", "jperez@gmail.com", "jperez", "1234");

            Issue i1 = AddIssue("12", m1);
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
        bool Login(string login, string password) {
            foreach(User u in dal.GetAll<User>()) 
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
        bool SignUp(string id, string name, string surname, bool alerted, string areasOfInterest, string email, string login, string password)
        {
            Boolean encontrado = false;
            foreach (User u in dal.GetAll<User>())
            {
                if (u.comprobarId(id) )
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
        public void EnviarPaper(Area area, String Title, List<String> lista) {
            if (lista.Count <= 4) {
                dal.Insert();
            }
        }
        public void ServicioEvaluatePaper(Paper paper, Boolean decision, String comentarios) {
            Evaluation evaluacion = new Evaluation(decision, comentarios, DateTime.Now);
            paper.Evaluation = evaluacion;
            Area areaPaper = paper.BelongingArea;
            if (decision)
            {
                areaPaper.PublicationPending.Add(paper);
            }
            else { areaPaper.EvaluationPending.Remove(paper);  }
        }
        public void ListarArticuloyPaper(string filtro) {
            Boolean existe = false;
            ICollection<Paper> ListaFiltrada;
            if (filtro.Equals("")){
            }
            else {
                foreach (Issue i in dal.GetAll<Issue>()){
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
        //public Paper getPapers(Area area) { }


        #endregion


        #region Issue
        Issue BuildIssue(int id,int number){
            Boolean trobada = false;
            Issue resp;
            foreach (Issue i in dal.GetAll<Issue>()) {
                if (i.Number == number) { trobada = true; }
            }
            if (trobada == true)
            {
                resp = dal.GetById<Issue>(number);
            }
            else {
                Area areaSelec = dal.GetById<Area>(id);
                foreach (Paper p in areaSelec.Papers) {
                    areaSelec.PublicationPending.Add(p);
                    areaSelec.EvaluationPending.Add(p);
                }
            }
            return resp;
        }

        public Issue AddIssue(int number, Magazine.Entities.Magazine magazine)
        {
            Issue issue = new Issue(number, magazine);
            dal.Insert<Issue>(issue);
            Commit();
            return issue;
        }

        #endregion

        #region Area
        public Area AddArea(String name, User editor, Entities.Magazine magazine) {
            Area area = new Area(name, editor, magazine);
            dal.Insert<Area>(area);
            Commit();
            return area;
        }
        public ICollection<Area> listAreas() 
        {
            ICollection<Area> list = magazine.gAreas();
            return list;
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
        #endregion
    }
}
