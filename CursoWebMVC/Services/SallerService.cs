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

        public void Insert(Saller saller)
        {
            _context.Add(saller);
            _context.SaveChanges();
        }

        public Saller FindById(int id)
        {
            return _context.Saller.FirstOrDefault(obj => obj.Id == id);
        }
        
        public void Remove(int id)
        {
            var obj = _context.Saller.Find(id);
            _context.Saller.Remove(obj);
            _context.SaveChanges();
        }


    }
}
