using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using View;
using System.Windows.Forms;

namespace Controller
{
    class StartController
    {
        public LeitorDeArquivoController Lac { get; set; } 

        public StartController()
        {
            Lac = new LeitorDeArquivoController();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


        }

        public void start()
        {
            PlanoDeAula p = new PlanoDeAula();
        
          
            Application.Run(p);
            Console.ReadLine();
        }

    }
}
