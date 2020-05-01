using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoWebMVC.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Saller Saller { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
