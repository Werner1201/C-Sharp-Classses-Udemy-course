using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Controller;

namespace Controller
{
    class PesquisaController
    {
        public Pesquisa p { get; set; } = new Pesquisa();
        public CurriculoController cc { get; set; } = new CurriculoController();
        public DisciplinaController dc { get; set; }  = new DisciplinaController();
        public HabilidadeController hc { get; set; } = new HabilidadeController();

        public PesquisaController()
        {
        }

        public HabilidadeController pesquisaPorCodigoHabilidade(string codigo, Curriculo curriculo)
        {
            cc.Curriculo = curriculo;
            dc.Disciplina = cc.pesquisaDisciplinaCodigo(codigo);
            hc.habilidade = dc.pesquisaHabilidadeDeUmaDisciplina(codigo);
            return hc;
        }

    }
}
