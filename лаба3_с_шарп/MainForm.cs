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
        List<Device> devices = new List<Device>();
        DigitalCamera photo = new DigitalCamera("Sony", "f/2.8", 4, 4, 1000);
        public MainForm()
        {
            InitializeComponent();
        }

        public void add(Device divace)
        {
            devices.Add(divace);
        }

        public void output()
        { 
            listBox1.Items.Clear();
            foreach (DigitalCamera photo in devices)
            {
                listBox1.Items.Add(photo.brand + " " + photo.diaphragms + " " + photo.zoom.ToString() + " " + photo.memory.ToString() + " " + photo.battery_volume.ToString());
            }

        }

        public void enab (bool state)
        {
            PowerButton.Enabled = state;
            FotoButton.Enabled = state;
            DelFotoButton.Enabled = state;
            WatchButton.Enabled = state;
            ZoomingButton.Enabled = state;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            enab(false);
            TurnOffButton.Enabled = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Input form = new Input();
            form.Owner = this;
            form.ShowDialog();
            output();
            listBox1.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (devices.Count > 0)
            {
                devices.RemoveAt(listBox1.SelectedIndex);
                output();
            }
            else
            {
                MessageBox.Show("Добавьте хотя бы 1 элемент");
            }
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            int value = new Random().Next(0, 100);
            MessageBox.Show(photo.power(value));
        }

        private void FotoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(photo.foto());
        }

        private void DelFotoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(photo.delete_photo());
        }

        private void WatchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(photo.watch_photo());
        }

        private void NearButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(photo.zooming(true));
        }

        private void FarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(photo.zooming(false));
        }

        private void TurnOnButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(photo.status(true));
            enab(true);
            TurnOffButton.Enabled = true;
        }

        private void TurnOffButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(photo.status(false));
            enab(false);
            TurnOffButton.Enabled = false;
        }
    }
}
