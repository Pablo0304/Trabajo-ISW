﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Person
    {
        public Person() 
        {
            //Colecciones
            CoAuthoredPapers = new List<Paper>();
        }

        public Person(String id, String name, String surname) :this()
        {   
            this.Id = id;
            this.Name = name;
            this.Surname = surname;

        }
    }
}
