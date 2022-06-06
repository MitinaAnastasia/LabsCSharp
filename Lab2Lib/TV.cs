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
        private string _producingCountry; //дополнительное поле: Страна-производитель
        public TV(string firm, int diagonal, int soundPower, string producingCountry) : base(firm, diagonal, soundPower) //конструктор
        {
            _producingCountry = producingCountry;
        }

        public string GetProducingCountry()
        {
            return _producingCountry;
        }

        public void SetProducingCountry(string producingCountry)
        {
            _producingCountry = producingCountry;
        }

        public override double QualityOfTV() //функция, которая определяет качество объекта класса 2-го уровня по заданной формуле 
        {
            double quality = base.QualityOfTV();
            double qualityProd;
            if (GetProducingCountry() == "Япония")
            {
                qualityProd = 2 * quality;
            }
            else if (GetProducingCountry() == "Сингапур" || GetProducingCountry() == "Корея")
            {
                qualityProd = 1.5 * quality;
            }
            else
            {
                qualityProd = quality;
            }
            return qualityProd;
        }

        public override string MakeStr() // возвращает строку для вывода в листбокс класса 2-го уровня
        {
            return base.MakeStr() + ", Страна-производитель: " + GetProducingCountry();
        }
    }

}
