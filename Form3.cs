namespace WinFormListaC
{
    public partial class Form3 : Form
    {
        private int valor1;
        private int valor2;

        public Form3()
        {
            InitializeComponent();
        }

        private void value1_TextChanged(object sender, EventArgs e)
        {
            TryParseValues();
        }

        private void value2_TextChanged(object sender, EventArgs e)
        {
            TryParseValues();
        }

        private void escolha_TextChanged(object sender, EventArgs e)
        {
            PerformOperation();
        }

        private void TryParseValues()
        {
            try
            {
                valor1 = Convert.ToInt32(value1.Text);
                valor2 = Convert.ToInt32(value2.Text);
                PerformOperation();
            }
            catch
            {
                MessageBox.Show("Preencha todos os valores corretamente.");
            }
        }

        private void PerformOperation()
        {
            if (string.IsNullOrEmpty(value1.Text) || string.IsNullOrEmpty(value2.Text))
            {
                return;
            }

            string operation = escolha.Text.Trim().ToLower();

            int result = 0;

            if (operation == "1" || operation == "soma")
            {
                result = valor1 + valor2;
                labelRes.Text = "Resultado da Soma: " + result.ToString();
            }
            else if (operation == "2" || operation == "multiplicação")
            {
                result = valor1 * valor2;
                labelRes.Text = "Resultado da Multiplicação: " + result.ToString();
            }
            else
            {
                labelRes.Text = "Digite '1' (Soma) ou '2' (Multiplicação) no campo de escolha.";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void BTNprox_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            this.Hide();
        }

        private void BTNvoltar_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }
    }
}