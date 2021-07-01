using System;
using System.Collections.Generic;
using System.Text;

namespace Praticando_Classes_03
{
    class Student
    {
        public string Name;
        public double Score1;
        public double Score2;
        public double Score3;

        public double FinalScore()
        {
            return Score1 + Score2 + Score3; 
        }

        public override string ToString()
        {
            return Name + FinalScore();
        }
    }
}
