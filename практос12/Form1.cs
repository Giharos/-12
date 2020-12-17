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
        //расчёт к заданию 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(numFirstValue.Text, out int One) && Int32.TryParse(numFirstValue2.Text, out int Two) && Int32.TryParse(numSecondValue.Text, out int Three) && Int32.TryParse(numSecondValue2.Text, out int Four))
            {
                One = Convert.ToInt32(numFirstValue.Text);
                Two = Convert.ToInt32(numSecondValue.Text);
                Three = Convert.ToInt32(numFirstValue2.Text);
                Four = Convert.ToInt32(numSecondValue2.Text);
                Lib_12.Koordinat tochki = new Koordinat(One, Two);
                Lib_12.Koordinat tochki2 = new Koordinat(Three, Four);
                double result = tochki.Rasstoyanie(tochki, tochki2);
                rez1.Text = result.ToString();
                numFirstValue.Focus();
            }
            else MessageBox.Show("Введите правильное значение");
        }
        //расчёт к заданию 2
        private void button2_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(textBox5.Text);

            Lib_12.Chislo chislo = new Chislo(first);
            //Произведение
            int proizv = chislo.GetMultiplay();
            rez2.Text = proizv.ToString();
            textBox5.Focus();
        }
        //выход
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //о программе
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа 13\n" +
                "Платов Андрей вариант 12\n" +
                "1.Найти расстояние между двумя точками с заданными координатами  (x1, y1) и (x2, y2) на плоскости. Расстояние вычисляется по формуле.\n" +
                "2.Дано трехзначное число. Используя одну операцию деления нацело, вывести первую цифру данного числа (сотни).");
        }
        //очистить задание 2
        private void clear2_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            rez2.Clear();
        }
        //очистить задание 1
        private void clear1_Click(object sender, EventArgs e)
        {
            numFirstValue.Clear();
            numFirstValue2.Clear();
            numSecondValue.Clear();
            numSecondValue2.Clear();
        }
        //Дата и время
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            //Создание объекта 
            statusStrip1.Items[0].Text = d.ToString("HH:mm");//Время
            statusStrip1.Items[1].Text = d.ToString("dd.MM.yyyy");//Дата 
        }

        private void numFirstValue_TextChanged(object sender, EventArgs e)
        {
            rez1.Clear();
        }

        private void numFirstValue2_TextChanged(object sender, EventArgs e)
        {
            rez1.Clear();
        }

        private void numSecondValue_TextChanged(object sender, EventArgs e)
        {
            rez1.Clear();
        }

        private void numSecondValue2_TextChanged(object sender, EventArgs e)
        {
            rez1.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            rez2.Clear();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Контекстное меню вызов
        private void numFirstValue_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void numSecondValue_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void numFirstValue2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void numSecondValue2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void textBox5_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip2.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }
    }
}
