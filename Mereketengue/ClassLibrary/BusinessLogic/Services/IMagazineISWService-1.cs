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
        User getLoggedUser();
        #region User
        /// <summary>   Performs login validation and logs in </summary>
        /// <param>     <c>login</c> is the user login name 
        /// </param>
        /// <param>     <c>password</c> is the user password for login. 
        /// </param>
        /// <returns>   Any required ServiceExceptions
        ///             userId if login succeeds
        /// </returns>
        bool Login(string login, string password);

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
        bool SignUp(string id, string name, string surname, bool alerted, bool suscribed, string areasOfInterest, string email, string login, string password);
        User SearchUser(String name);
        Entities.User AddUser(string id, string name, string surname, bool alerted, bool suscribed, string areasOfInterest, string email, string login, string password);
        #endregion

        #region Paper
        Paper EnviarPaper(Area area, string Title);
        void EvaluatePaper(Area area, Paper paper, Boolean decision, string comentarios);
        ICollection<Paper> ListarPapersRechazados(Area area);
        ICollection<Paper> ListarPublishedPapers(Area area);
        ICollection<Paper> ListarPapersPublPending(Area area);
        ICollection<Paper> ListarPapersEvPending(Area area);
        Paper SearchPaper(String name, Area area);
        Entities.Paper AddPaper(string title, DateTime uploadDate, Area belongingArea, User responsible);
        #endregion

        #region Issue
        Issue searchIssue(int number);
        void eliminarPublishedpapers(ICollection<Paper> papers);
        Issue BuildIssue(int number, DateTime publicationDate, ICollection<Paper> listaPapersAux, float price, float discount);
        Issue AddIssue(int number, Magazine.Entities.Magazine magazine, float discount, float price, DateTime pubtime);
        Issue CreateIssue(DateTime fecha, int number, Magazine.Entities.Magazine magazine, ICollection<Paper> listaPapersAux, float discount, float price);
        void EditIssue(Issue issue, ICollection<Paper> publishedPapers,DateTime pubdate, float discount, float price);
        ICollection<Issue> getAllIssues();
        Issue getLastIssue();
        Boolean pendingPublication(Issue issue);
        ICollection<Paper> getPendingPublicationPapers(Area area);
        ICollection<Paper> getPendingEvaluationPapers(Area area);

        #endregion

        #region Area
        Entities.Area  AddArea(string name, User editor, Entities.Magazine magazine);

        Area SearchArea(String name);
        #endregion

        #region Magazine
        Magazine.Entities.Magazine AddMagazine(string name, User chiefEditorId);
        ICollection<Area> listAreas();
        Entities.Magazine getMagazine();
        #endregion

        #region Person
        Person addCoauthor(string id,string name, string surname, Paper paper);
        void deleteCoauthor(Person person, Paper paper); //añadido
        Person AddPerson(string id, string name, string surname);
        Person SearchPerson(String name);
        #endregion 
        User gLoggedUser();
    }
}
