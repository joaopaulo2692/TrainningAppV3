using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TrainningApp.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public float? Heigth { get; set; }
        public string? Gender { get; set; }
        public float? Weight { get; set; }
        public int? GymId { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [Column("disabled_at")]
        public DateTime? DisabledAt { get; set; }

        public virtual List<Trainning> Trainnings { get; set; }
        public virtual List<Management> Managements { get; set; }
        public virtual Gym Gym { get; set; }
    }
}
