using System.Collections.Generic;
using System.Linq;
using CursoWebMVC.Models;

namespace CursoWebMVC.Services
{
    public class DepartmentService
    {
        private readonly CursoWebMVCContext _context;

        public DepartmentService(CursoWebMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
