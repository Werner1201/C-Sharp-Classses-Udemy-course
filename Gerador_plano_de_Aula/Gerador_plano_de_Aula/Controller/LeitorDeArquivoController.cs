using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Model;

namespace Controller
{
    class LeitorDeArquivoController
    {
        public static LeitorDeArquivo Leitor { get; set; } = new LeitorDeArquivo();

        public LeitorDeArquivoController()
        {
        }
        

        public Curriculo getCurriculo()
        {
            return Leitor.curriculo;
        }
    }
}
