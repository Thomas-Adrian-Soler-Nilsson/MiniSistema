namespace WinFormListaC
{
    partial class Form2
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
            fileSystemWatcher1 = new FileSystemWatcher();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            labelRes = new Label();
            BTNprox = new Button();
            BTNvoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(275, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 45);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(275, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 45);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(275, 123);
            label2.Name = "label2";
            label2.Size = new Size(96, 33);
            label2.TabIndex = 2;
            label2.Text = "Valor 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 17);
            label1.Name = "label1";
            label1.Size = new Size(92, 33);
            label1.TabIndex = 3;
            label1.Text = "Valor 1";
            // 
            // labelRes
            // 
            labelRes.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRes.ForeColor = SystemColors.ControlText;
            labelRes.Location = new Point(12, 250);
            labelRes.Name = "labelRes";
            labelRes.Size = new Size(776, 60);
            labelRes.TabIndex = 4;
            labelRes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTNprox
            // 
            BTNprox.Font = new Font("Comic Sans MS", 15.75F);
            BTNprox.Location = new Point(668, 398);
            BTNprox.Name = "BTNprox";
            BTNprox.Size = new Size(120, 40);
            BTNprox.TabIndex = 5;
            BTNprox.Text = "Proximo";
            BTNprox.UseVisualStyleBackColor = true;
            BTNprox.Click += BTNprox_Click;
            // 
            // BTNvoltar
            // 
            BTNvoltar.Font = new Font("Comic Sans MS", 15.75F);
            BTNvoltar.Location = new Point(12, 398);
            BTNvoltar.Name = "BTNvoltar";
            BTNvoltar.Size = new Size(120, 40);
            BTNvoltar.TabIndex = 6;
            BTNvoltar.Text = "Voltar";
            BTNvoltar.UseVisualStyleBackColor = true;
            BTNvoltar.Click += BTNvoltar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNvoltar);
            Controls.Add(BTNprox);
            Controls.Add(labelRes);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private TextBox textBox1;
        private Label labelRes;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button BTNvoltar;
        private Button BTNprox;
    }
}