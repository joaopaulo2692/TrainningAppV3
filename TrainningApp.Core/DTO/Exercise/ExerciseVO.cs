using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.Entities;

namespace TrainningApp.Core.DTO.Exercise
{
    public class ExerciseVO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Video { get; set; }
        //public virtual List<int> MusclesIds { get; set; }

        public virtual List<string> Muscles { get; set; }
    }
}
