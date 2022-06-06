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
        private string _name;
        private double _musicLength;
        private Styles _style;

        public Musical_composition(string name, double musicLength, Styles style) //конструктор
        {
            _name = name;
            _musicLength = musicLength;
            _style = style;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public double GetMusic_length()
        {
            return _musicLength;
        }

        public void SetMusic_length(double musicLength)
        {
            _musicLength = musicLength;
        }

        public Styles GetStyle()
        {
            return _style;
        }

        public void SetStyle(Styles style)
        {
            _style = style;
        }

        public string MakeStr() // возвращает строку для вывода в листбокс
        {
            return "Название: " + GetName() + ", Продолжительность: " + GetMusic_length() + ", Стиль: " + GetStyle();
        }
    }
}
