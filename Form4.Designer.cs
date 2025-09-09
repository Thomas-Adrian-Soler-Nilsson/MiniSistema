namespace WinFormListaC
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxGenero = new ComboBox();
            textBoxName = new TextBox();
            textBoxIdade = new TextBox();
            label5 = new Label();
            LabelRes = new Label();
            BTNVoltar = new Button();
            BTNProximo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 35);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 0;
            label1.Text = "Leitor de nom, genero e idade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(237, 81);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(225, 124);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 2;
            label3.Text = "Genero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(244, 165);
            label4.Name = "label4";
            label4.Size = new Size(73, 32);
            label4.TabIndex = 3;
            label4.Text = "Idade";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Masculino", "Femino", "Outros" });
            comboBoxGenero.Location = new Point(340, 133);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(121, 23);
            comboBoxGenero.TabIndex = 4;
            comboBoxGenero.SelectedIndexChanged += comboBoxGenero_SelectedIndexChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(340, 90);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(121, 23);
            textBoxName.TabIndex = 5;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxIdade
            // 
            textBoxIdade.Location = new Point(340, 174);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(121, 23);
            textBoxIdade.TabIndex = 6;
            textBoxIdade.TextChanged += textBoxIdade_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 25F);
            label5.Location = new Point(317, 253);
            label5.Name = "label5";
            label5.Size = new Size(167, 46);
            label5.TabIndex = 7;
            label5.Text = "Resultado";
            // 
            // LabelRes
            // 
            LabelRes.AutoSize = true;
            LabelRes.Location = new Point(335, 293);
            LabelRes.Name = "LabelRes";
            LabelRes.Size = new Size(0, 15);
            LabelRes.TabIndex = 8;
            // 
            // BTNVoltar
            // 
            BTNVoltar.Font = new Font("Comic Sans MS", 15.75F);
            BTNVoltar.Location = new Point(21, 399);
            BTNVoltar.Name = "BTNVoltar";
            BTNVoltar.Size = new Size(106, 39);
            BTNVoltar.TabIndex = 9;
            BTNVoltar.Text = "Voltar";
            BTNVoltar.UseVisualStyleBackColor = true;
            // 
            // BTNProximo
            // 
            BTNProximo.Font = new Font("Comic Sans MS", 15.75F);
            BTNProximo.Location = new Point(659, 399);
            BTNProximo.Name = "BTNProximo";
            BTNProximo.Size = new Size(129, 39);
            BTNProximo.TabIndex = 10;
            BTNProximo.Text = "Proximo";
            BTNProximo.UseVisualStyleBackColor = true;
            BTNProximo.Click += BTNProximo_Click_1;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNProximo);
            Controls.Add(BTNVoltar);
            Controls.Add(LabelRes);
            Controls.Add(label5);
            Controls.Add(textBoxIdade);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxGenero);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxGenero;
        private TextBox textBoxName;
        private TextBox textBoxIdade;
        private Label label5;
        private Label LabelRes;
        private Button BTNVoltar;
        private Button BTNProximo;
    }
}