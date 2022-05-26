﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    public class Picture:IId
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public int? PlacementId { get; set; }//-
        public virtual Placement Placement { get; set; }
        public int? GenreId { get; set; }//-
        public virtual Genre Genre { get; set; }
        public int? ArtistId { get; set; }//-
        public virtual Artist Artist { get; set; }
    }
}
