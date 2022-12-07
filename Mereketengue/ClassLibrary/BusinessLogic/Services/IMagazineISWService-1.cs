using Magazine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Magazine.Services
{
    public interface IMagazineISWService
    {

        // YOU MAY ADD ANY ADDITIONAL NEEDED SERVICES TO THIS INTERFACE

        /// <summary>   Initializes Database with some data</summary>        
        void DBInitialization();

        #region User
        void SignUp(string name, string surname, string email, string password, string areasOfInterest, bool alerted);
        /// <summary>   Performs login validation and logs in </summary>
        /// <param>     <c>login</c> is the user login name 
        /// </param>
        /// <param>     <c>password</c> is the user password for login. 
        /// </param>
        /// <returns>   Any required ServiceExceptions
        ///             userId if login succeeds
        /// </returns>
        string Login(string login, string password);

        /// <summary>   Performs a log out operation </summary>
        void Logout();

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
        User AddUser(string id, string name, string surname, bool alerted, string areasOfInterest, string email, string login, string password);

        #endregion

        #region Paper
        // void addPaper(String Title, DateTime uploaddate, Area evaluationPendingArea, Area belongingArea, Area publicationPendingArea, User responsible
        void EnviarPaper(Area area, String Title, List<String> lista);
        void ServicioEvaluatePaper(Area area);
        void ListarArticuloyPaper();
        #endregion

        #region Issue
        void BuildIssue();


        #endregion

        #region Area
        Entities.Area  AddArea(String name, User editor, Entities.Magazine magazine);
        #endregion

        #region Magazine
        Entities.Magazine AddMagazine(string name, User chiefEditorId);


        #endregion
    }
}
