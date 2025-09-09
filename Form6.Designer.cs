namespace WinFormListaC
{
    partial class Form6
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
            textBoxIdade = new TextBox();
            labelRes = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxIdade
            // 
            textBoxIdade.Location = new Point(269, 78);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(164, 23);
            textBoxIdade.TabIndex = 0;
            textBoxIdade.TextChanged += textBoxIdade_TextChanged;
            // 
            // labelRes
            // 
            labelRes.AutoSize = true;
            labelRes.Font = new Font("Segoe UI", 30F);
            labelRes.Location = new Point(252, 160);
            labelRes.Name = "labelRes";
            labelRes.Size = new Size(198, 54);
            labelRes.TabIndex = 1;
            labelRes.Text = "Resultado";
            labelRes.Click += Resultado_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(175, 69);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 2;
            label2.Text = "Idade:";
            label2.Click += label2_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 367);
            Controls.Add(label2);
            Controls.Add(labelRes);
            Controls.Add(textBoxIdade);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIdade;
        private Label labelRes;
        private Label label2;
    }
}