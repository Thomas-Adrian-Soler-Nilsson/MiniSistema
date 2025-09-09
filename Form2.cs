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
    public partial class Form2 : Form
    {
        private int valor1;
        private int valor2;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToInt32(textBox1.Text);
                if (valor1 > valor2)
                {
                    labelRes.Text = valor1.ToString() + " É o maior numero";
                }
                else
                {
                    labelRes.Text = valor2.ToString() + " É o maior numero";
                }
            }
            catch
            {
                MessageBox.Show("Preencha todos os valores");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valor2 = Convert.ToInt32(textBox2.Text);
                if (valor2 > valor1)
                {
                    labelRes.Text = valor2.ToString() + " É o maior numero";
                }
                else
                {
                    labelRes.Text = valor1.ToString() + " É o maior numero";
                }
            }
            catch
            {
                MessageBox.Show("Preencha todos os valores");

            }
        }

        private void BTNprox_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            this.Hide();
        }

        private void BTNvoltar_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }
    }
}
