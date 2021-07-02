using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeracao_Composicao.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirhtDate { get; set; }

        public Client() { }

        public Client(string name, string email, DateTime birhtDate)
        {
            Name = name;
            Email = email;
            BirhtDate = birhtDate;
        }
    }
}
