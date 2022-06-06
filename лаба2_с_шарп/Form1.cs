using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Лаба №2. Задача 19. Построить класс 1-го уровня с указанными в индивидуальном задании полями и методами: 
конструктор; 
функция, которая определяет «качество» объекта – Q  по заданной формуле (столбец 2); 
вывод информации об объекте.   
Построить класс 2-го уровня (класс-потомок), который содержит: 
дополнительное поле P; 
функция, которая определяет «качество» объекта класса 2-го уровня – Qp, которая перекрывает функцию качества класса 1-го уровня (Q ), выполняя вычисление по новой формуле (столбец 3).  
Создать проект для демонстрации работы: ввод и вывод информации об объектах классов 1-го и 2-го уровней. 

Задача 19. 
Телевизор: фирма, диагональ экрана (дюйм), звуковая мощность (дб), Q = диагональ+(0,05·мощность);
для производного: P:  страна-производитель, Qp: если страна - Япония, то Qp=2·Q;  а если Сингапур или Корея, то Qp=1,5·Q; иначе Qp=Q */

namespace лаба2_с_шарп
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

        public List<Televisions> Televisions = new List<Televisions>(); 
        public List<TV> TV = new List<TV>();

        private void WithCountrycheckbtn_CheckedChanged(object sender, EventArgs e) 
        {
            if (withCountrycheckbtn.Checked)
            {
                MessageBox.Show("Вы можете ввести страну в соответствующий TextBox");
                CountrytextBox.Enabled = true;
            }
        }

        private void WithoutCountrycheckbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (withoutCountrycheckbtn.Checked)
            {
                CountrytextBox.Enabled = false;
            }
        }


        private void InputButton_Click(object sender, EventArgs e) //добавление, если не выбрать страну производства, то дабвление в один список, если выбрана страна производства, то и во второй
        {
            Televisions.Add(new Televisions(FirmtextBox.Text, Int32.Parse(DiagonaltextBox.Text), Int32.Parse(SoundPowtextBox.Text)));
            if (withCountrycheckbtn.Checked)
            {
                TV.Add(new TV(FirmtextBox.Text, Int32.Parse(DiagonaltextBox.Text), Int32.Parse(SoundPowtextBox.Text), CountrytextBox.Text));
            }
        }

        private void OutputButton_Click(object sender, EventArgs e) //вывод в 2 листбокса + указано качество телевизоров будет
        {
            FirstClasslistBox.Items.Clear();
            int count = Televisions.Count;
            for (int i = 0; i < count; i++)
            {
                FirstClasslistBox.Items.Add((i + 1).ToString() + ". " + Televisions[i].MakeStr() + ", Качество объекта: " + Televisions[i].QualityOfTV());
            }
            SecondClasslistBox.Items.Clear();
            int count_2 = TV.Count;
            for (int i = 0; i < count_2; i++)
            {
                SecondClasslistBox.Items.Add((i + 1).ToString() + ". " + TV[i].MakeStr() + ", Качество объекта: " + TV[i].QualityOfTV());
            }
        }
    }
}
