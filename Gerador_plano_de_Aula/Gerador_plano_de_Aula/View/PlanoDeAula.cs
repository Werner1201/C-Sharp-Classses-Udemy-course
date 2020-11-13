using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class PlanoDeAula : Form
    {
        public PlanoDeAula()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grupoSegunda_Enter(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupBox[] gbv = new GroupBox[5] {grupoSegunda, GrupoTerca, grupoQuarta, grupoQuinta, grupoSexta};


            if(grupoSegunda.Height > 25)
            {
                grupoSegunda.Height = 25;
                button1.Text = "+";
                foreach (GroupBox gb in gbv)
                {
                    if (!gb.Equals(grupoSegunda))
                    {
                        gb.Location = new Point(gb.Location.X, gb.Location.Y - 300);
                    }
                }
            }
            else
            {
                foreach (GroupBox gb in gbv)
                {
                    if (!gb.Equals(grupoSegunda))
                    {
                        gb.Location = new Point(gb.Location.X, gb.Location.Y + 300);
                    }
                }
                grupoSegunda.Height = 423;
                button1.Text = "-";

            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            GroupBox[] gbv = new GroupBox[5] { grupoSegunda, GrupoTerca, grupoQuarta, grupoQuinta, grupoSexta };
            if (GrupoTerca.Height > 25)
            {
                GrupoTerca.Height = 25;
                button2.Text = "+";
                foreach (GroupBox gb in gbv)
                {
                    if (!gb.Equals(GrupoTerca))
                    {
                        gb.Location = new Point(gb.Location.X, gb.Location.Y - 300);
                    }
                }
            }
            else
            {
                foreach (GroupBox gb in gbv)
                {
                    if (!gb.Equals(GrupoTerca))
                    {
                        gb.Location = new Point(gb.Location.X, gb.Location.Y + 300);
                    }
                }
                GrupoTerca.Height = 423;
                button2.Text = "-";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GroupBox[] gbv = new GroupBox[5] { grupoSegunda, GrupoTerca, grupoQuarta, grupoQuinta, grupoSexta };
            if (grupoQuarta.Height > 25)
            {
                grupoQuarta.Height = 25;
                button3.Text = "+";
                foreach (GroupBox gb in gbv)
                {
                    if (!gb.Equals(grupoQuarta))
                    {
                        gb.Location = new Point(gb.Location.X, gb.Location.Y - 300);
                    }
                }
            }
            else
            {
                foreach (GroupBox gb in gbv)
                {
                    if (!gb.Equals(grupoQuarta))
                    {
                        gb.Location = new Point(gb.Location.X, gb.Location.Y + 300);
                    }
                }
                grupoQuarta.Height = 423;
                button3.Text = "-";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GroupBox[] gbv = new GroupBox[5] { grupoSegunda, GrupoTerca, grupoQuarta, grupoQuinta, grupoSexta };
            if (grupoQuinta.Height > 25)
            {
                grupoQuinta.Height = 25;
                button4.Text = "+";
                foreach (GroupBox gb in gbv)
                {
                    if (!gb.Equals(grupoQuinta))
                    {
                        gb.Location = new Point(gb.Location.X, gb.Location.Y - 300);
                    }
                }
            }
            else
            {
                foreach (GroupBox gb in gbv)
                {
                    if (!gb.Equals(grupoQuinta))
                    {
                        gb.Location = new Point(gb.Location.X, gb.Location.Y + 300);
                    }
                }
                grupoQuinta.Height = 423;
                button4.Text = "-";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GroupBox[] gbv = new GroupBox[5] { grupoSegunda, GrupoTerca, grupoQuarta, grupoQuinta, grupoSexta };
            if (grupoSexta.Height > 25)
            {
                grupoSexta.Height = 25;
                button5.Text = "+";
                foreach (GroupBox gb in gbv)
                {
                    if (!gb.Equals(grupoSexta))
                    {
                        gb.Location = new Point(gb.Location.X, gb.Location.Y - 300);
                    }
                }
            }
            else
            {
                foreach (GroupBox gb in gbv)
                {
                    if (!gb.Equals(grupoSexta))
                    {
                        gb.Location = new Point(gb.Location.X, gb.Location.Y + 300);
                    }
                }
                grupoSexta.Height = 423;
                button5.Text = "-";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DocumentoController dc = new DocumentoController();

        }
    }
}
