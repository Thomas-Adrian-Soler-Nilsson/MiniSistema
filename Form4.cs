using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormListaC
{
    public partial class Form4 : Form
    {
        private int Idade;
        private string Nome;
        public Form4()
        {
            InitializeComponent();
            LabelRes.Text = "";
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            Nome = textBoxName.Text;

            if (!string.IsNullOrEmpty(textBoxIdade.Text) && comboBoxGenero.SelectedItem != null)
            {
                if (comboBoxGenero.SelectedItem.ToString() == "Feminino" && Idade < 25)
                {
                    LabelRes.Text = "ACEITA";
                }
                else
                {
                    LabelRes.Text = "NÃO ACEITA";
                }
            }
        }

        private void textBoxIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBoxIdade_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxIdade.Text) && comboBoxGenero.SelectedItem != null)
            {
                Idade = Convert.ToInt32(textBoxIdade.Text);

                if (comboBoxGenero.SelectedItem.ToString() == "Feminino" && Idade < 25)
                {
                    LabelRes.Text = "ACEITA";
                }
                else
                {
                    LabelRes.Text = "NÃO ACEITA";
                }
            }
        }

        private void comboBoxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxIdade.Text) && comboBoxGenero.SelectedItem != null)
            {
                if (comboBoxGenero.SelectedItem.ToString() == "Feminino" && Idade < 25)
                {
                    LabelRes.Text = "ACEITA";
                }
                else
                {
                    LabelRes.Text = "NÃO ACEITA";
                }
            }
        }

        private void BTNVoltar_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Close();
        }

        private void BTNProximo_Click_1(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Close();
        }

        

        
    }
}