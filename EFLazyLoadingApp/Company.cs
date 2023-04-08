using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLazyLoadingApp
{
    public class Company
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public virtual List<Employee> Employees { get; set; } = new();
        
    }
}
