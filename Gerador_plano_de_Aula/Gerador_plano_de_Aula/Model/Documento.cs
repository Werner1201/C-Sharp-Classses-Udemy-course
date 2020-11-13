using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Documento
    {
        public List<dynamic> Linhas { get; set; } = new List<dynamic>();
        public Dictionary<string, string> Tabela { get; set; } = new Dictionary<string, string>();

        public Documento()
        {
        }
    }
}
