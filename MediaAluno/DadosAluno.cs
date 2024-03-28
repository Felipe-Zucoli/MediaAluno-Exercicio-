using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAluno
{
    internal class DadosAluno
    {
        public string name;
        public double nota1;
        public double nota2;
        public double nota3;

        public double media ()
        {
            return nota1 + nota2 + nota3; 
        }
    }
}
