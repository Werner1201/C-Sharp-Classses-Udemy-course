using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;
using System.Configuration;
using System.Data;

namespace Data
{
    class LeitorDeArquivo
    {
        public string json { get; set; }
        public Curriculo curriculo { get; set; }

        public LeitorDeArquivo()
        {

            using (StreamReader r = new StreamReader(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\dados.json")))
            {
                this.json = r.ReadToEnd();
            }
            this.Populate();
        }
        
        public void Populate()
        {
            List<Disciplina> vetor = this.Alocate();
            this.curriculo = new Curriculo(vetor);
        }

        public List<Disciplina> Alocate()
        {
            List<Disciplina> array = JsonConvert.DeserializeObject<List<Disciplina>>(this.json);
            return array;
        }
        
    }
}
