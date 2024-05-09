namespace AmericanDream
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.AceitarBtn = new System.Windows.Forms.Button();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.TelBox = new System.Windows.Forms.TextBox();
            this.TipoBox = new System.Windows.Forms.ComboBox();
            this.Aceitar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AceitarBtn
            // 
            this.AceitarBtn.Location = new System.Drawing.Point(387, 189);
            this.AceitarBtn.Name = "AceitarBtn";
            this.AceitarBtn.Size = new System.Drawing.Size(185, 23);
            this.AceitarBtn.TabIndex = 0;
            this.AceitarBtn.Text = "Adicionar";
            this.AceitarBtn.UseVisualStyleBackColor = true;
            this.AceitarBtn.Click += new System.EventHandler(this.AceitarBtn_Click);
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(323, 54);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(314, 20);
            this.NomeBox.TabIndex = 1;
            // 
            // TelBox
            // 
            this.TelBox.Location = new System.Drawing.Point(323, 92);
            this.TelBox.Name = "TelBox";
            this.TelBox.Size = new System.Drawing.Size(314, 20);
            this.TelBox.TabIndex = 2;
            // 
            // TipoBox
            // 
            this.TipoBox.FormattingEnabled = true;
            this.TipoBox.Items.AddRange(new object[] {
            "Zap",
            "Comercial",
            "Pessoal"});
            this.TipoBox.Location = new System.Drawing.Point(323, 130);
            this.TipoBox.Name = "TipoBox";
            this.TipoBox.Size = new System.Drawing.Size(314, 21);
            this.TipoBox.TabIndex = 3;
            // 
            // Aceitar
            // 
            this.Aceitar.AutoSize = true;
            this.Aceitar.Location = new System.Drawing.Point(441, 166);
            this.Aceitar.Name = "Aceitar";
            this.Aceitar.Size = new System.Drawing.Size(70, 17);
            this.Aceitar.TabIndex = 4;
            this.Aceitar.Text = "Aceito ze";
            this.Aceitar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(257, 263);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 95);
            this.listBox1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(464, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(464, 302);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(464, 337);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(173, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aceitar);
            this.Controls.Add(this.TipoBox);
            this.Controls.Add(this.TelBox);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.AceitarBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AceitarBtn;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.TextBox TelBox;
        private System.Windows.Forms.ComboBox TipoBox;
        private System.Windows.Forms.CheckBox Aceitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

