﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Evaluation
    {
        public Evaluation()
        {
        }

        public Evaluation(bool accepted, string comments, DateTime date) : this()
        {
            this.Accepted = accepted;
            this.Comments = comments;
            this.Date = date;
        }
        public bool gdecision() 
        { 
            return this.Accepted; 
        }
    }
}
