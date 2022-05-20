using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace лаба1_с_шарп
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Disc listtr = new Disc();

        private void OutputButton_Click(object sender, EventArgs e) //выводит сборку на диске в нужном формате в листбокс при нажатии на кнопку "Вывести сборку на диске"
        {
            listBox.Items.Clear();
            int count = listtr.tracklist.Count;
            for (int i = 0; i < count; i++)
            {
                listBox.Items.Add((i + 1).ToString() + ". " + listtr.tracklist[i].makeStr());
            }
        }

        private void DisclenButton_Click(object sender, EventArgs e) // при нажатии на кнопку "продолжительность диска" выведет его продолжительность в текстбокс
        {
            LengthBox.Clear();
            LengthBox.Text += listtr.discLength();
        }


        public bool check(string str) /* проверка на наличие посторонних символов в строке, допускаются только цифры, или точка, или запятая. Если какой-либо символ строки не удовлетворяет,
        то возвращаем false, иначе true*/
        {
            int i = 0;
            Regex r = new Regex(@"[\d.,]");
            Match m = r.Match(str);
            while (m.Success)
            {
                i++;
                m = m.NextMatch();
            }
            if (i!=str.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void FindButton_Click(object sender, EventArgs e) /*поиск треков в заданном диапазоне, сначала вводится начало и конец в соответствующие текстбоксы, нажимаем на "Узнать трек",
        если они удовлетворяют всем проверкам, то находим наши треки, если таковых нет, то нам это и выведут*/
        {
            ResTextBox.Clear();
            if (BeginTextBox.Text != "" && EndTextBox.Text != "" && check(BeginTextBox.Text) && check(EndTextBox.Text))
            {
                double first = double.Parse(BeginTextBox.Text.Replace('.', ','));
                double last = double.Parse(EndTextBox.Text.Replace(".", ","));
                string str = listtr.findByRange(first, last);
                if (str == "")
                {
                    ResTextBox.Text += "Нет треков в заданном диапазоне";
                }
                else
                {
                    ResTextBox.Text += str;
                }
            }
            else
            {
                MessageBox.Show("Вам нужно ввести начало и конец диапазона в соответствующие TextBox, можно вводить только числа с точкой или запятой");
            }
        }

        private void SortButton_Click(object sender, EventArgs e) //сортировка по стилю, если наш стиль существует, то сортируем по нему
        {
            string input_style = StyletextBox.Text;
            if (Enum.IsDefined(typeof(Styles), input_style))
            {
                listBox.Items.Clear();
                int count = listtr.tracklist.Count;
                var sortlist = listtr.sortByStyles((Styles)Enum.Parse(typeof(Styles), input_style));
                for (int i = 0; i < count; i++)
                    listBox.Items.Add((i + 1).ToString() + ". " + sortlist[i].makeStr());
            }
            else
            {
                MessageBox.Show("Такого стиля нет");
            }
        }
    }
}
