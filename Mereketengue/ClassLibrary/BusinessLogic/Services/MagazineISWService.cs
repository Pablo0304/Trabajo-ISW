using Magazine.Entities;
using Magazine.Persistence;
using System;
using System.Collections.Generic;
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

            User user = AddUser("1234", "MC", "Penades", false, "documentos", "mpenades@gmail.com", "mpenades", "1234");
      
            AddMagazine("Revista Universitària UUPPVV", user);


            AddUser("2345", "Ana", "Nunez", false, "emergencias", "anunez@gmail.com", "anunez", "1234");
            Area a1 = new Area("Area A1", u2, m);
            AddArea(a1);

            User u3 = new User("3456", "Jose", "Garcia", false, "pruebas", "jgarcia@gmail.com", "jgarcia", "1234");
            AddUser(u3);
            Area a2 = new Area("Area 2", u3, m);
            AddArea(a2);

         
            User u4 = new User("4567", "Juan", "Perez", false, "software", "jperez@gmail.com", "jperez", "1234");
            AddUser(u4);
        }

        #region User
        void SignUp(string name, string surname, string email, string password, string areasOfInterest, bool alerted) { }
        /// <summary>   Performs login validation and logs in </summary>
        /// <param>     <c>login</c> is the user login name 
        /// </param>
        /// <param>     <c>password</c> is the user password for login. 
        /// </param>
        /// <returns>   Any required ServiceExceptions
        ///             userId if login succeeds
        /// </returns>
        string Login(string login, string password) { 
        
        }

        /// <summary>   Performs a log out operation </summary>
        void Logout() { }

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
        User AddUser(string id, string name, string surname, bool alerted, string areasOfInterest, string email, string login, string password) {
            if (!dal.Exists<User>(login))
            {
                User user = new User(id, name, surname, alerted, areasOfInterest, email, login, password);
                dal.Insert<User>(user);
                return user;
            }
            else { throw new ServiceException("User already exists."); }
        }

        #endregion


        #region Paper
        public void EnviarPaper(Area area, String Title) {
            if (dal.) { }
        }
        public void ServicioEvaluatePaper(Area area) { }
        public void ListarArticuloyPaper() { }
        #endregion


        #region Issue
        Issue BuildIssue(int number){
            if (dal.Exists<Issue>(number))
            {
                dal.GetById<Issue>(number);
            }
            else { 
                
            }
        }

        #endregion

        #region Area

        

        #endregion

        #region Magazine
        public void AddMagazine(String name, User chiefEditorId) {
            Entities.Magazine magazine = new Entities.Magazine(name, chiefEditorId);
        }
        #endregion
    }
}
