using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Model
{
    class Disciplina
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("habilidades")]
        public List<Habilidade> Habilidades { get; set; }
        public List<Habilidade> Dump { get; set; }

        public Disciplina(string nome, List<Habilidade> habilidades)
        {
            Nome = nome;
            Habilidades = habilidades;
        }

        
    }
}
