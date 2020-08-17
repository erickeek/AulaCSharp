using System;

namespace AulaCSharp.Exceptions
{
    public class PermissaoException : Exception
    {
        public PermissaoException() : base("Você não tem permissão")
        {
            
        }
    }
}