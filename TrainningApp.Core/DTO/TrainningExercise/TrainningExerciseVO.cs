﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Core.DTO.TrainningExercise
{
    public class TrainningExerciseVO
    {
        public int Id { get; set; }
        public string ExerciseName { get; set; }
        public int Set { get; set; }
        public string Reps { get; set; }
        public string Interval { get; set; }
        public string Weight { get; set; }
        public int Ordenation { get; set; }
        public string Info { get; set; }
        public int ExerciseId { get; set; }
        public int TrainningDayId { get; set; }

    }
}
