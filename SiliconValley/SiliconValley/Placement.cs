﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    public class Placement:IId
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
