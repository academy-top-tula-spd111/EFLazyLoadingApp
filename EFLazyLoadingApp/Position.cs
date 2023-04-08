﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLazyLoadingApp
{
    public class Position
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public virtual List<Employee> Employees { get; set; } = new();
    }
}
