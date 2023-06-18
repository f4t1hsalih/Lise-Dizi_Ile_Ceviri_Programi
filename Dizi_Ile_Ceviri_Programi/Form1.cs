using System;
using System.Windows.Forms;

namespace Dizi_Ile_Ceviri_Programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] turkce = { "elma", "araba", "kitap" };
        string[] ingilizce = { "apple", "car", "book" };

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (a == turkce[0]) textBox2.Text = ingilizce[0];
            else if (a == turkce[1]) textBox2.Text = ingilizce[1];
            else if (a == turkce[2]) textBox2.Text = ingilizce[2];
            else if (a == ingilizce[0]) textBox2.Text = turkce[0];
            else if (a == ingilizce[1]) textBox2.Text = turkce[1];
            else if (a == ingilizce[2]) textBox2.Text = turkce[2];
            else MessageBox.Show("Sistemde olmayan bir kelime girdiniz");
        }
    }
}
