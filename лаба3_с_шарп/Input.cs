using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Для интерфейса необходимо определить 1 свойство и 2 метода. 
Абстрактный класс должен содержать 3-5 свойств и 3-5 методов(включая унаследованные свойства интерфейса). 
Класс должен содержать дополнительно 2 свойства и 2 метода.
В программе реализовать работу со списком объектов, который должен содержать объекты типа интерфейса.

19. interface Устройство -> abstract class Фотоаппарат -> class Цифровой фотоаппарат.*/


namespace лаба3_с_шарп
{
    public partial class Input : Form
    {
        IDevice Divace;
        public Input()
        {
            InitializeComponent();
        }

        private void Input_Load(object sender, EventArgs e)
        {

        }

        public void input()
        {
            string brand = BrandTextBox.Text;
            string diaf = DiafTextBox.Text;
            int zoom = Int32.Parse(ZoomTextBox.Text);
            int memory = Int32.Parse(MemoryTextBox.Text);
            int volume = Int32.Parse(VolumeTextBox.Text);
            Divace = new DigitalCamera(brand, diaf, zoom, memory, volume);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            input();
            MainForm main = this.Owner as MainForm;
            main.Add(Divace);
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
