using Magazine.Entities;
using Magazine.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ProgramA
{
    public static void Main(string[] args)
    {
        IDAL dal = new EntityFrameworkDAL(new MagazineDbContext());

        DBInitialization();
    }
}