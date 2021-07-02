using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Exercicio_Resovido_Composicao2.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
