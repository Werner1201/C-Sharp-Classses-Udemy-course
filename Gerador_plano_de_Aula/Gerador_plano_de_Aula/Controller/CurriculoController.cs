using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class CurriculoController
    {
        public Curriculo Curriculo { get; set; }
        public DisciplinaController disciplinaController { get; set; }
        public HabilidadeController habilidadeController { get; set; }

        public CurriculoController()
        {
        }

        public CurriculoController(Curriculo curriculo)
        {
            this.Curriculo = curriculo;
        }

        public Disciplina pesquisaDisciplina(string nome)
        {
            try
            {
                Disciplina disciplina = Curriculo.Disciplinas.FirstOrDefault(d => d.Nome.Equals(nome));
                return disciplina;

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                List<Habilidade> list = new List<Habilidade>();
                list.Add(new Habilidade("ERRO", "ERRO", "ERRO", "ERRO"));
                return new Disciplina("Erro", list);
            }
        }

        public Disciplina pesquisaDisciplinaCodigo(string codigo)
        {

            string cut = codigo.Substring(4, 2);
            Disciplina disciplina = Curriculo.Disciplinas.Find(d => d.Habilidades[0].Codigo.Substring(5, 2).Equals(cut));
            return disciplina;
        }

    }
}
