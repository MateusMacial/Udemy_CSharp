using System;

namespace Praticando_excecoes.Entities.DomainExceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
