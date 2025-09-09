namespace WinFormListaC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                try
                {
                    int Valor = Convert.ToInt32(textBox.Text);

                    if (Valor % 2 == 0)
                    {
                        LBLParOuInp.Text = "Par";
                    }
                    else
                    {
                        LBLParOuInp.Text = "Impar";
                    }
                }
                catch
                {
                    MessageBox.Show("Erro, não use letras");
                }
            }

        }

        private void BTNProximo_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }
    }
}
