using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormListaC
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIdade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxIdade.Text) <= 16)
                {
                    labelRes.Text = "Não eleitor";
                }
                if (Convert.ToInt32(textBoxIdade.Text) == 17)
                {
                    labelRes.Text = "Não foi definido";
                }
                else if (Convert.ToInt32(textBoxIdade.Text) >= 18 && Convert.ToInt32(textBoxIdade.Text) < 65)
                {
                    labelRes.Text = "Eleitor obrigatório";
                }
                else if (Convert.ToInt32(textBoxIdade.Text) > 16 && Convert.ToInt32(textBoxIdade.Text) < 18 || Convert.ToInt32(textBoxIdade.Text) > 65)
                {
                    labelRes.Text = "Eleitor opcional";
                }
            }
            catch
            {
                labelRes.Text = "Erro, prencha sua idade";

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
