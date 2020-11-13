using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Curriculo
    {
        public List<Disciplina> Disciplinas { get; set; }

        public Curriculo(List<Disciplina> disciplinas)
        {
            Disciplinas = disciplinas;
        }
    }
}
