using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class TV : Televisions //класс 2-го уровня
    {
        private string producing_country; //дополнительное поле: Страна-производитель
        public TV(string firm, int diagonal, int sound_power, string producing_country) : base(firm, diagonal, sound_power) //конструктор
        {
            this.producing_country = producing_country;
        }

        public string getProducingCountry()
        {
            return producing_country;
        }

        public void setProducingCountry(string producing_country)
        {
            this.producing_country = producing_country;
        }

        public override double qualityOfTV() //функция, которая определяет качество объекта класса 2-го уровня по заданной формуле 
        {
            double Q = base.qualityOfTV();
            double Qp = 0;
            if (getProducingCountry() == "Япония")
            {
                Qp = 2 * Q;
            }
            else if (getProducingCountry() == "Сингапур" || getProducingCountry() == "Корея")
            {
                Qp = 1.5 * Q;
            }
            else
            {
                Qp = Q;
            }
            return Qp;
        }

        public override string makeStr() // возвращает строку для вывода в листбокс класса 2-го уровня
        {
            return base.makeStr() + ", Страна-производитель: " + getProducingCountry();
        }
    }

}
