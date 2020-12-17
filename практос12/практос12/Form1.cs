using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_12;

namespace практос12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(numFirstValue.Text);
            int secondNumber = Convert.ToInt32(numSecondValue.Text);
            int firstNumber2 = Convert.ToInt32(numFirstValue2.Text);
            int secondNumber2 = Convert.ToInt32(numSecondValue2.Text);
            Lib_12.Koordinat tochki = new Koordinat(firstNumber, secondNumber);
            Lib_12.Koordinat tochki2 = new Koordinat(firstNumber2, secondNumber2);
            double result = tochki.Rasstoyanie(tochki,tochki2);
            rez1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(textBox5.Text);
            
            Lib_12.Chislo chislo = new Chislo(first);
            //Произведение
            int proizv = chislo.GetMultiplay();
            rez2.Text = proizv.ToString();
        }
    }
}
