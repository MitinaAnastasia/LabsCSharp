using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Звукозапись.
Определить иерархию музыкальных композиций. Записать на диск сборку. 
Подсчитать продолжительность. Провести перестановку композиций диска на основе принадлежности к стилю. 
Найти композицию, соответствующую заданному диапазону длины треков.*/


namespace лаба1_с_шарп
{
    public enum Styles //набор стилей треков
    {
        ROCK, POP, METAL, ALTERNATIVE, CLASSICAL, JAZZ, RAP, ELECTRONIC, DISCO, HIPHOP_RAP
    }

    public class Musical_composition //класс, который хранит в себе название песни, ее продолжительность и стиль
    {
        private string name;
        private double music_length;
        private Styles style;

        public Musical_composition(string name, double music_length, Styles style) //конструктор
        {
            this.name = name;
            this.music_length = music_length;
            this.style = style;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public double getMusic_length()
        {
            return music_length;
        }

        public void setMusic_length(double music_length)
        {
            this.music_length = music_length;
        }

        public Styles getStyle()
        {
            return style;
        }

        public void setStyle(Styles style)
        {
            this.style = style;
        }

        public string makeStr() // возвращает строку для вывода в листбокс
        {
            return "Название: " + getName() + ", Продолжительность: " + getMusic_length() + ", Стиль: " + getStyle();
        }
    }
}
