﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigrationApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int? Age { get; set; }
        //public Company? Company { get; set; }
    }
}
