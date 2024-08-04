﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Core.Entities
{
    public class Trainning
    {
        public int Id { get; set; }
        public virtual List<ApplicationUser> Users { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [Column("disabled_at")]
        public DateTime? DisabledAt { get; set; }
    }
}
