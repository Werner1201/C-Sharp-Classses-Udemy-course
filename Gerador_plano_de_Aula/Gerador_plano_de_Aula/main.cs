using System;
using Controller;
using System.Windows.Forms;

namespace Gerador_plano_de_Aula
{
   class PontoDeInicio
    {
        [STAThread]
        static void Main(string[] args)
        {
            StartController sc = new StartController();
            sc.start();
           
           
        }
    }


}