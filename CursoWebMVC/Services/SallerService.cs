using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoWebMVC.Models;

namespace CursoWebMVC.Services
{
    public class SallerService
    {
        private readonly CursoWebMVCContext _context;

        public SallerService(CursoWebMVCContext context)
        {
            _context = context;
        }

        public List<Saller> findAll()
        {
            return _context.Saller.ToList();
        }
            


    }
}
