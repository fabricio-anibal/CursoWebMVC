using System;


namespace CursoWebMVC.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base (message)
        {
        }
    }
}
