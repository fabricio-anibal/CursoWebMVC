using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoWebMVC.Models
{
    public class Saller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();


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
