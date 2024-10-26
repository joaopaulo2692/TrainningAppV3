﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Core.Entities
{
    public class Gym : BaseEntities
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<ApplicationUser> Personals { get; set; }
        public virtual List<ApplicationUser> Users { get; set; }
        public virtual List<ApplicationUser> Administrators { get; set; }
    }
}
