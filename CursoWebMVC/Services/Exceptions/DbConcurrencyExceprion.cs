using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoWebMVC.Services.Exceptions
{
    public class DbConcurrencyExceprion : ApplicationException
    {
        public DbConcurrencyExceprion(string message) : base(message)
        {
        }
    }
}
