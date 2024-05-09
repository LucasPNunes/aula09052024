using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmericanDream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void AceitarBtn_Click(object sender, EventArgs e)
        {
            string nome = NomeBox.Text;
            string tel = TelBox.Text;
            var tipo = TipoBox.SelectedItem.ToString();
            if (Aceitar.Checked)
            {
                listBox1.Items.Add(new Contato(nome, tel, tipo));
            }
            else
            {
                MessageBox.Show("Você precisa aceitar os termos zé.");
            }
        }
    }
}
