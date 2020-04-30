using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Saller> Sallers { get; set; } = new List<Saller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void addSaller(Saller saller)
        {
            Sallers.Add(saller);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            return Sallers.Sum(x => x.totalSales(initial, final));
        }
    }
}
