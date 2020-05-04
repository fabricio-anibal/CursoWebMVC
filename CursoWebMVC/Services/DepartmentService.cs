using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoWebMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoWebMVC.Services
{
    public class DepartmentService
    {
        private readonly CursoWebMVCContext _context;

        public DepartmentService(CursoWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
