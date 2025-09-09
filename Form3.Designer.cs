namespace WinFormListaC
{
    partial class Form3
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
            escolha = new TextBox();
            value1 = new TextBox();
            value2 = new TextBox();
            Titulo = new Label();
            label1 = new Label();
            labelRes = new Label();
            BTNprox = new Button();
            BTNvoltar = new Button();
            SuspendLayout();
            // 
            // escolha
            // 
            escolha.Location = new Point(260, 310);
            escolha.Name = "escolha";
            escolha.Size = new Size(280, 23);
            escolha.TabIndex = 0;
            escolha.TextChanged += escolha_TextChanged;
            // 
            // value1
            // 
            value1.Location = new Point(260, 132);
            value1.Name = "value1";
            value1.Size = new Size(280, 23);
            value1.TabIndex = 1;
            value1.TextChanged += value1_TextChanged;
            // 
            // value2
            // 
            value2.Location = new Point(260, 194);
            value2.Name = "value2";
            value2.Size = new Size(280, 23);
            value2.TabIndex = 2;
            value2.TextChanged += value2_TextChanged;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Comic Sans MS", 21.75F);
            Titulo.Location = new Point(251, 28);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(298, 40);
            Titulo.TabIndex = 3;
            Titulo.Text = "Soma ou multipliação";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 21.75F);
            label1.Location = new Point(336, 237);
            label1.Name = "label1";
            label1.Size = new Size(128, 40);
            label1.TabIndex = 4;
            label1.Text = "Escolha:";
            // 
            // labelRes
            // 
            labelRes.AutoSize = true;
            labelRes.Location = new Point(271, 354);
            labelRes.Name = "labelRes";
            labelRes.Size = new Size(0, 15);
            labelRes.TabIndex = 5;
            // 
            // BTNprox
            // 
            BTNprox.Location = new Point(698, 406);
            BTNprox.Name = "BTNprox";
            BTNprox.RightToLeft = RightToLeft.No;
            BTNprox.Size = new Size(75, 23);
            BTNprox.TabIndex = 6;
            BTNprox.Text = "Proximo";
            BTNprox.UseVisualStyleBackColor = true;
            BTNprox.Click += BTNprox_Click;
            // 
            // BTNvoltar
            // 
            BTNvoltar.Location = new Point(27, 406);
            BTNvoltar.Name = "BTNvoltar";
            BTNvoltar.Size = new Size(75, 23);
            BTNvoltar.TabIndex = 7;
            BTNvoltar.Text = "Voltar";
            BTNvoltar.UseVisualStyleBackColor = true;
            BTNvoltar.Click += BTNvoltar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNvoltar);
            Controls.Add(BTNprox);
            Controls.Add(labelRes);
            Controls.Add(Titulo);
            Controls.Add(value2);
            Controls.Add(value1);
            Controls.Add(escolha);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox escolha;
        private TextBox value1;
        private TextBox value2;
        private Label Titulo;
        private Label label1;
        private Label labelRes;
        private Button BTNprox;
        private Button BTNvoltar;
    }
}