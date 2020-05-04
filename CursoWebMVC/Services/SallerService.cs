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

        public async Task<List<Saller>> findAllAsync()
        {
            return await _context.Saller.ToListAsync();
        }

        public async Task InsertAsync(Saller saller)
        {
            _context.Add(saller);
            await _context.SaveChangesAsync();
        }

        public async Task<Saller> FindByIdAsync(int id)
        {
            return await _context.Saller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Saller.FindAsync(id);
            _context.Saller.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Saller obj)
        {
            bool hasAny = await _context.Saller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("ID not found");
            }

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyExceprion(e.Message);
            }
        }


    }
}
