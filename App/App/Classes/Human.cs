﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public class Human
    {
        public int Id { get; set; }
        [MaxLength(50)] 
        public string Name { get; set; }
    }
}
