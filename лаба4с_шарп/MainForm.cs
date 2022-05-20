using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DivaceLib;
using System.Reflection;

/*Взять за основу задачу 6 (номер 19). Должно быть не менее 3 классов, которые наследуются от абстрактного класса. 
Используя рефлексию реализовать возможность создания  и вызова методов данных классов на форме.
Написать код, который принимает путь к библиотеке классов и ищет все классы, которые реализуют интерфейс.
Далее получают всю информацию о данных классах, и возвращают список из названий классов.
На форме реализовать «дроплаун» с названиями классов.
При выборе класса на форму должны динамически подгружаться все методы класса с возможностью ввода параметров пользователем. 
При нажатии кнопки «Выполнить» должен создаваться объект и выполняться выбранный метод.
*/

namespace лаба4с_шарп
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Assembly SampleAssembly = Assembly.LoadFrom("DivaceLib.dll");
        Type t;

        private void Form1_Load(object sender, EventArgs e)
        {
            var test = GetTypesWithInterface(SampleAssembly);
            var true_class = test.Where(elem => elem.GetInterface("Divace") != null).ToList();
            foreach (var i in true_class)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }


        private IEnumerable<Type> GetTypesWithInterface(Assembly asm)
        {
            var it = typeof(DivaceLib.Divace);
            return asm.GetLoadableTypes().Where(it.IsAssignableFrom).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            t = SampleAssembly.GetType(comboBox1.SelectedItem.ToString());
            var main = t.GetMethods().Where(p =>  p.ReturnType == typeof(string) && p.Name != "ToString" && p.Name.Substring(0, 4) != "get_");
            listBox1.Items.Clear();
            foreach (var mi in main)
            {
                listBox1.Items.Add(mi.ToString());
            }
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            if(!t.IsAbstract)
            {
                object myObj = Activator.CreateInstance(t, new object[] { });
                MessageBox.Show("Содан объект класса " + myObj.ToString());
                int start = listBox1.SelectedItem.ToString().IndexOf(' ') + 1;
                int end = listBox1.SelectedItem.ToString().IndexOf('(') - start;
                var par = t.GetMethod(listBox1.SelectedItem.ToString().Substring(start, end));
                ParameterInfo[] pi = par.GetParameters();
                object[] args = new object[1];
                if (pi.Length == 0)
                {
                    MessageBox.Show(par.Invoke(myObj, null).ToString());
                }
                else
                {
                    if (pi[0].ParameterType == typeof(bool))
                    {
                        args[0] = new Random().Next(2) == 0 ? false : true;
                        MessageBox.Show(par.Invoke(myObj, args).ToString());
                    }
                    if (pi[0].ParameterType == typeof(Int32))
                    {
                        args[0] = new Random().Next(0, 100);
                        MessageBox.Show(par.Invoke(myObj, args).ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не можете создать объект абстрактного класса");
            }

        }
    }


    public static class TypeLoaderExtensions
    {
        public static IEnumerable<Type> GetLoadableTypes(this Assembly assembly)
        {
            if (assembly == null) throw new ArgumentNullException("assembly");
            try
            {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                return e.Types.Where(t => t != null);
            }
        }
    }
}
