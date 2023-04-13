using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // a^2 + b^2 = c^2     =>   trójkąt jest prostokątny

            //deklaracja zmiennych
            double a, b, c;

            //przechwycenie zmiennych od użytkownika
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            // a * a == Math.Pow(a,2)
            bool czyTrojkatProstokatny = Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2);

            //Wyskakujące okienko z wynikiem
            MessageBox.Show($"Czy trójkąt jest prostokątny? {czyTrojkatProstokatny}", "Wynik");

        }
    }
}
