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

        private string firm;
        private int diagonal;
        private int sound_power;

        public Televisions() //конструктор по умолчанию
        {

        }

        public Televisions(string firm, int diagonal, int sound_power) //конструктор с параметрами
        {
            this.firm = firm;
            this.diagonal = diagonal;
            this.sound_power = sound_power;
        }

        public string getFirm()
        {
            return firm;
        }

        public void setFirm(string firm)
        {
            this.firm = firm;
        }

        public int getDiagonal()
        {
            return diagonal;
        }

        public void setDiagonal(int diagonal)
        {
            this.diagonal = diagonal;
        }

        public int getSound_power()
        {
            return sound_power;
        }

        public void setSound_power(int sound_power)
        {
            this.sound_power = sound_power;
        }

        public virtual double qualityOfTV() //функция, которая определяет качество объекта по заданной формуле для класса 1-го уровня
        {
            double Q = getDiagonal() + (0.05 * getSound_power());
            return Q;
        }

        public virtual string makeStr() // возвращает строку для вывода в листбокс класса 1-го уровня
        {
            return "Фирма: " + getFirm() + ", Диагональ экрана: " + getDiagonal() + " дюйм, Звуковая мощность: " + getSound_power() + " дБ";
        }

    }
}
