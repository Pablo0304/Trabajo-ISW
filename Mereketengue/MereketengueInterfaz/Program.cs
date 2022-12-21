using Magazine.Persistence;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MereketengueInterfaz
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IMagazineISWService service = new MagazineISWService(new EntityFrameworkDAL(new MagazineDbContext()));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            service.DBInitialization();
            Application.Run(new Login(service));
        }
    }
}
