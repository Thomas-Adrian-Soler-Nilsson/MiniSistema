namespace WinFormListaC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox = new TextBox();
            label1 = new Label();
            LBLParOuInp = new Label();
            BTNProximo = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(287, 110);
            textBox.Margin = new Padding(8);
            textBox.Name = "textBox";
            textBox.Size = new Size(251, 48);
            textBox.TabIndex = 0;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 62);
            label1.Name = "label1";
            label1.Size = new Size(368, 40);
            label1.TabIndex = 1;
            label1.Text = "Digite um Numero Inteiro";
            // 
            // LBLParOuInp
            // 
            LBLParOuInp.Anchor = AnchorStyles.None;
            LBLParOuInp.AutoSize = true;
            LBLParOuInp.Location = new Point(382, 206);
            LBLParOuInp.Name = "LBLParOuInp";
            LBLParOuInp.Size = new Size(61, 40);
            LBLParOuInp.TabIndex = 2;
            LBLParOuInp.Text = "Par";
            LBLParOuInp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTNProximo
            // 
            BTNProximo.AutoSize = true;
            BTNProximo.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNProximo.Location = new Point(692, 459);
            BTNProximo.Name = "BTNProximo";
            BTNProximo.Size = new Size(120, 40);
            BTNProximo.TabIndex = 3;
            BTNProximo.Text = "Proximo";
            BTNProximo.UseVisualStyleBackColor = true;
            BTNProximo.Click += BTNProximo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 511);
            Controls.Add(BTNProximo);
            Controls.Add(LBLParOuInp);
            Controls.Add(label1);
            Controls.Add(textBox);
            Font = new Font("Comic Sans MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(8);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Label label1;
        private Label LBLParOuInp;
        private Button BTNProximo;
    }
}
