namespace WindowsFormsApp1
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
            this.CleberBox = new System.Windows.Forms.ComboBox();
            this.TextCleber = new System.Windows.Forms.TextBox();
            this.Clebertao = new System.Windows.Forms.Button();
            this.ListBoxZe = new System.Windows.Forms.ListBox();
            this.CleberCopia = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CleberBox
            // 
            this.CleberBox.FormattingEnabled = true;
            this.CleberBox.Location = new System.Drawing.Point(203, 192);
            this.CleberBox.Name = "CleberBox";
            this.CleberBox.Size = new System.Drawing.Size(521, 21);
            this.CleberBox.TabIndex = 0;
            this.CleberBox.SelectedIndexChanged += new System.EventHandler(this.CleberBox_SelectedIndexChanged);
            // 
            // TextCleber
            // 
            this.TextCleber.Location = new System.Drawing.Point(378, 144);
            this.TextCleber.Name = "TextCleber";
            this.TextCleber.Size = new System.Drawing.Size(100, 20);
            this.TextCleber.TabIndex = 1;
            this.TextCleber.TextChanged += new System.EventHandler(this.TextCleber_TextChanged);
            // 
            // Clebertao
            // 
            this.Clebertao.Location = new System.Drawing.Point(203, 144);
            this.Clebertao.Name = "Clebertao";
            this.Clebertao.Size = new System.Drawing.Size(75, 23);
            this.Clebertao.TabIndex = 2;
            this.Clebertao.Text = "Adicionar";
            this.Clebertao.UseVisualStyleBackColor = true;
            this.Clebertao.Click += new System.EventHandler(this.Clebertao_Click);
            // 
            // ListBoxZe
            // 
            this.ListBoxZe.FormattingEnabled = true;
            this.ListBoxZe.Location = new System.Drawing.Point(203, 278);
            this.ListBoxZe.Name = "ListBoxZe";
            this.ListBoxZe.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBoxZe.Size = new System.Drawing.Size(275, 95);
            this.ListBoxZe.TabIndex = 3;
            this.ListBoxZe.SelectedIndexChanged += new System.EventHandler(this.ListBoxZe_SelectedIndexChanged);
            // 
            // CleberCopia
            // 
            this.CleberCopia.Location = new System.Drawing.Point(203, 233);
            this.CleberCopia.Name = "CleberCopia";
            this.CleberCopia.Size = new System.Drawing.Size(75, 23);
            this.CleberCopia.TabIndex = 4;
            this.CleberCopia.Text = "Copia zé";
            this.CleberCopia.UseVisualStyleBackColor = true;
            this.CleberCopia.Click += new System.EventHandler(this.CleberCopia_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(546, 278);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 95);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Copiar selecionados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CleberCopia);
            this.Controls.Add(this.ListBoxZe);
            this.Controls.Add(this.Clebertao);
            this.Controls.Add(this.TextCleber);
            this.Controls.Add(this.CleberBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CleberBox;
        private System.Windows.Forms.TextBox TextCleber;
        private System.Windows.Forms.Button Clebertao;
        private System.Windows.Forms.ListBox ListBoxZe;
        private System.Windows.Forms.Button CleberCopia;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

