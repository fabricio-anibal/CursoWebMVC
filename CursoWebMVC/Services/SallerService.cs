using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoWebMVC.Models;
using Microsoft.EntityFrameworkCore;
using CursoWebMVC.Services.Exceptions;

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
            return _context.Saller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }
        
        public void Remove(int id)
        {
            var obj = _context.Saller.Find(id);
            _context.Saller.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Saller obj)
        {
            if (!_context.Saller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("ID not found");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyExceprion(e.Message);
            }
        }


    }
}
