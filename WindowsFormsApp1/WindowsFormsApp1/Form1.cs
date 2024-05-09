using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CleberBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clebertao_Click(object sender, EventArgs e)
        {
            if (TextCleber.Text.ToString() != " " &&
            TextCleber.Text.ToString() != " ")
            {
                CleberBox.Items.Add(TextCleber.Text.ToString().ToUpper());
                TextCleber.Clear();
            }
        }

        private void TextCleber_TextChanged(object sender, EventArgs e)
        {

        }

        private void CleberCopia_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < CleberBox.Items.Count; i++)
                ListBoxZe.Items.Add((string)CleberBox.Items[i].ToString());
        }

        private void ListBoxZe_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< ListBoxZe.SelectedItems.Count; i++)
                listBox1.Items.Add((string)ListBoxZe.SelectedItems[i].ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
