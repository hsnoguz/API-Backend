﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Model
{
  public partial class Aim
    {
        public int Id { get; set; }
        public string Explanation { get; set; }
        public int PeriotId { get; set; }
        public DateTime? InsertTime { get; set; }
    
        public virtual List<Target> Targets { get; set; }

        public virtual Periot Periot { get; set; }

    }
}
