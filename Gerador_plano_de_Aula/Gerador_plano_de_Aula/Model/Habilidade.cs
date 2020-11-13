using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Habilidade
    {
        [JsonProperty("id")]
        public string Codigo { get; set; }

        [JsonProperty("desc")]
        public string Descricao { get; set; }

        [JsonProperty("tema")]
        public string Tema { get; set; }

        [JsonProperty("objDC")]
        public string ObjetoDeConhecimento { get; set; }

        public Habilidade(string codigo, string descricao, string tema, string objetoDeConhecimento)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Tema = tema;
            this.ObjetoDeConhecimento = objetoDeConhecimento;
        }
    }
}
