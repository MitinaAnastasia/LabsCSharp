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
    public partial class MainForm : Form
    {
        List<IDevice> Devices = new List<IDevice>();
        DigitalCamera Photo = new DigitalCamera("Sony", "f/2.8", 4, 4, 1000);
        public MainForm()
        {
            InitializeComponent();
        }

        public void Add(IDevice divace)
        {
            Devices.Add(divace);
        }

        public void Output()
        { 
            listBox1.Items.Clear();
            foreach (DigitalCamera photo in Devices)
            {
                listBox1.Items.Add(photo.Brand + " " + photo.Diaphragms + " " + photo.Zoom.ToString() + " " + photo.Memory.ToString() + " " + photo.BatteryVolume.ToString());
            }

        }

        public void Enab (bool state)
        {
            PowerButton.Enabled = state;
            FotoButton.Enabled = state;
            DelFotoButton.Enabled = state;
            WatchButton.Enabled = state;
            ZoomingButton.Enabled = state;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Enab(false);
            TurnOffButton.Enabled = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Input form = new Input();
            form.Owner = this;
            form.ShowDialog();
            Output();
            listBox1.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Devices.Count > 0)
            {
                Devices.RemoveAt(listBox1.SelectedIndex);
                Output();
            }
            else
            {
                MessageBox.Show("Добавьте хотя бы 1 элемент");
            }
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            int value = new Random().Next(0, 100);
            MessageBox.Show(Photo.Power(value));
        }

        private void FotoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Photo.DoPhoto());
        }

        private void DelFotoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Photo.delete_photo());
        }

        private void WatchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Photo.watch_photo());
        }

        private void NearButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Photo.Zooming(true));
        }

        private void FarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Photo.Zooming(false));
        }

        private void TurnOnButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Photo.Status(true));
            Enab(true);
            TurnOffButton.Enabled = true;
        }

        private void TurnOffButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Photo.Status(false));
            Enab(false);
            TurnOffButton.Enabled = false;
        }
    }
}
