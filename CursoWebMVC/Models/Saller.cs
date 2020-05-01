using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CursoWebMVC.Models
{
    public class Saller
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} required")]
        public string Email { get; set; }


        [Display(Name = "Birth Date")]
        [Required(ErrorMessage = "{0} required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = ("{0:dd/MM/yyyy}"))]
        public DateTime BirthDate { get; set; }


        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display (Name = "Base Salary")]
        [Required(ErrorMessage = "{0} required")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public Double BaseSalary { get; set; }


        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        public int DepartmentId { get; set; }


        public Saller()
        {
        }

        public Saller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name  = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void addSale(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void removeSale(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.Amount);
        }
    }
}
