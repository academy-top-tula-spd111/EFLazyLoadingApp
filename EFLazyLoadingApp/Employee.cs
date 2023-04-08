using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLazyLoadingApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { set; get; }
        public virtual Company? Company { set; get; }
        public int? CompanyId { set; get; }
        public virtual Position? Position { set; get; }
        public int PositionId { set; get; }
    }
}
