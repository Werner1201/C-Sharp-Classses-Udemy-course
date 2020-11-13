using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    class HabilidadeController
    {
        public Habilidade habilidade { get; set; }

        public HabilidadeController()
        {
        }

        public HabilidadeController(Habilidade habilidade)
        {
            this.habilidade = habilidade;
        }

        public string getCodigo()
        {
            return habilidade.Codigo;
        }

        public string getDescricao()
        {
            return habilidade.Descricao;
        }

        public string getTema()
        {
            return habilidade.Tema;
        }
        public string getObjDeConhecimento()
        {
            return habilidade.ObjetoDeConhecimento;
        }
    }
}
