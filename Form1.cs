using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace graf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, a = 0, b = 0, h = 0, m = 0, n = 0, t = 0;
            try
            {
                a = double.Parse(this.textBox1.Text);
                b = double.Parse(this.textBox2.Text);
                h = double.Parse(this.textBox3.Text);
                m = double.Parse(this.textBox7.Text);
                n = double.Parse(this.textBox8.Text);
                t = double.Parse(this.textBox9.Text);
            }catch
            {
                MessageBox.Show("Введено неправильное значение" );
            }
            x = a;
            while (x <= b)
            {
                y = ((m * Math.Pow(x, 2)) + n * x + t);
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double x1, y1, a1 = 0, b1 = 0, h1 = 0, t = 0, d = 0;
            try
            {
            a1 = double.Parse(this.textBox4.Text);
            b1 = double.Parse(this.textBox5.Text);
            h1 = double.Parse(this.textBox6.Text);
            t = double.Parse(this.textBox6.Text);
            d = double.Parse(this.textBox6.Text);
            }
            catch 
            {
                MessageBox.Show("Введено неправильное значение.");
            }
            x1 = a1;
            while (x1 <= b1)
            {
                y1 = Math.Pow(x1, t) + d; 
                this.chart2.Series[0].Points.AddXY(x1, y1);
                x1 += h1;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.chart2.Series[0].Points.Clear();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Инструкция по использованию программы, представляет собой кнопку, при клике откроется окно сообщений с текстом,также окно сообщений можно открыть с помощью клавиши F1 на клавиатуре." , "Инструкция по использованию программы");
            MessageBox.Show("2. На форме имеются два элемента chart (для вывода графиков).", "Инструкция по использованию программы");
            MessageBox.Show("3. Для первой графики используются две кнопки: Построить график и Очистить график.", "Инструкция по использованию программы");
            MessageBox.Show("4. Под кнопками, которые описаны выше, есть три поля для записи данных, которые будут использованы при построении графика" , "Инструкция по использованию программы");
            MessageBox.Show("5. Ввести значения для трёх полей. Только числовые значения (формата int)!", "Инструкция по использованию программы");
            MessageBox.Show("6. Справа первой графики также имеются три поля, для записи данных (От: числовое значение формата double, для левой границы. До: числовое значение формата double, для правой границы. И шаги, которые определяют промежутки между левой и правой границами.)", "Инструкция по использованию программы");
            MessageBox.Show("7. Для второго графика также имеются две кнопки и три поля справа (от, до, шаг)", "Инструкция по использованию программы");
            MessageBox.Show("Спасибо за внимание!", "Инструкция по использованию программы");
        }
        void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                button5_Click(button5, null);
            }
        }
    }
}