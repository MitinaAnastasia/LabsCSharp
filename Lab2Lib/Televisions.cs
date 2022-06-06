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
    public class Televisions //класс 1-го уровня
    {

        private string _firm;
        private int _diagonal;
        private int _soundPower;

        public Televisions() //конструктор по умолчанию
        {

        }

        public Televisions(string firm, int diagonal, int soundPower) //конструктор с параметрами
        {
            _firm = firm;
            _diagonal = diagonal;
            _soundPower = soundPower;
        }

        public string GetFirm()
        {
            return _firm;
        }

        public void SetFirm(string firm)
        {
            _firm = firm;
        }

        public int GetDiagonal()
        {
            return _diagonal;
        }

        public void SetDiagonal(int diagonal)
        {
            _diagonal = diagonal;
        }

        public int GetSoundPower()
        {
            return _soundPower;
        }

        public void SetSoundPower(int soundPower)
        {
            _soundPower = soundPower;
        }

        public virtual double QualityOfTV() //функция, которая определяет качество объекта по заданной формуле для класса 1-го уровня
        {
            double quality = GetDiagonal() + (0.05 * GetSoundPower());
            return quality;
        }

        public virtual string MakeStr() // возвращает строку для вывода в листбокс класса 1-го уровня
        {
            return "Фирма: " + GetFirm() + ", Диагональ экрана: " + GetDiagonal() + " дюйм, Звуковая мощность: " + GetSoundPower() + " дБ";
        }

    }
}
