using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class DisciplinaController
    {
        public Disciplina Disciplina { get; set; }

        public DisciplinaController()
        {
        }

        public DisciplinaController(Disciplina disciplina)
        {
            this.Disciplina = disciplina;
        }

        public Habilidade pesquisaHabilidadeDeUmaDisciplina(string codigo)
        {
            try
            {
                Habilidade result = Disciplina.Habilidades.Find(habi => habi.Codigo.Substring(1, 8).Equals(codigo));
                return result;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                return new Habilidade("Erro", "Erro", "Erro", "Erro");
            }
        }
    }
}
