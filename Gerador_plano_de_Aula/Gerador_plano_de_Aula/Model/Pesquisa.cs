using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Pesquisa
    {
        public string Codigo { get; set; }
        public string DisciplinaNome { get; set; }

        public Pesquisa()
        {
        }

        public Pesquisa(string codigo, string disciplinaNome)
        {
            Codigo = codigo;
            DisciplinaNome = disciplinaNome;
        }
    }
}
