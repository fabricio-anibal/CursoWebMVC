using CursoWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoWebMVC.Services
{
    public class SalesRecordService
    {
        private readonly CursoWebMVCContext _context;

        public SalesRecordService(CursoWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if(maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate);
            }
            return await result.Include(x => x.Saller).Include(x => x.Saller.Department).OrderByDescending(x => x.Date).ToListAsync();
        }
    }
}
