﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Core.Entities
{
    public class Trainning : BaseEntities
    {
        public int Id { get; set; }
        public string Goal { get; set; }
        public DateTime FirstDay{ get; set; }
        public DateTime LastDay{ get; set; }
        public string IdPersonal { get; set; }
        public string IdPersonalGym { get; set; }
        public int? GymId { get; set; }
        public virtual List<ApplicationUser> Users { get; set; }
        public virtual ApplicationUser Personal {  get; set; }
        public virtual ApplicationUser PersonalGym {  get; set; }
        public virtual List<TrainningDay> TrainningDays { get; set; }
        public virtual Gym Gym { get; set; }
        //public virtual List<TrainningExercise> TrainningExercises { get; set; }
     
    }
}
