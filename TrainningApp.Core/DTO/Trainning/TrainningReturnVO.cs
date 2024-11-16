using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Core.DTO.Trainning
{
    public class TrainningReturnVO
    {
        public int Id { get; set; }
        public string Goal { get; set; }
        public string Name { get; set; }
        public string PersonalName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
