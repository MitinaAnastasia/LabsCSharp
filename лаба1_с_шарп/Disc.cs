using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба1_с_шарп
{
    class Disc
    {
        public List<Musical_composition> tracklist; //список всех треков
        public Disc() // конструктор, который добавляет все треки
        {
            tracklist = new List<Musical_composition>();
            tracklist.Add(new Musical_composition("Эдвард Григ - В пещере горного короля ", 3.06, Styles.CLASSICAL));
            tracklist.Add(new Musical_composition("Король и шут - Кукла колдуна ", 3.22, Styles.ROCK));
            tracklist.Add(new Musical_composition("Нервы -  Нервы", 2.39, Styles.ROCK));
            tracklist.Add(new Musical_composition("Asper X - Смерть луны ", 3.21, Styles.ALTERNATIVE));
            tracklist.Add(new Musical_composition("Queen - Bohemian Rhapsody ", 5.55, Styles.ROCK));
            tracklist.Add(new Musical_composition("Максим Свобода - Воздух на сигареты ", 3.16, Styles.POP));
            tracklist.Add(new Musical_composition("Электрофорез - Я ничего не могу с собою сделать ", 4.32, Styles.ELECTRONIC));
            tracklist.Add(new Musical_composition("Мультик Энканто - Не упоминай Бруно ", 3.36, Styles.POP));
            tracklist.Add(new Musical_composition("GAYAZOVS BROTHERS - Малиновая лада ", 3.33, Styles.POP));
            tracklist.Add(new Musical_composition("Noize MC feat. Монеточка - Чайлдфри ", 4.04, Styles.HIPHOP_RAP));
            tracklist.Add(new Musical_composition("CMH - Диски-вписки ", 3.02, Styles.ELECTRONIC));
            tracklist.Add(new Musical_composition("Pyrokinesis - Я приду к тебе с клубникой в декабре ", 4.38, Styles.HIPHOP_RAP));
        }

        public double discLength() // метод, который находит продолжительность диска, проходит по нашему списку и вычисляет сумму продолжительностей всех треков
        {
            double len_disc = 0;
            for (int i = 0; i < tracklist.Count(); i++)
            {
                len_disc += tracklist[i].getMusic_length();
            }
            return len_disc;
        }

        public List<Musical_composition> sortByStyles(Styles style) //сортировка по стилю, передается стиль, а затем список сортируется, исходя из введенного стиля, возвращает отсартированный список
        {

            List<Musical_composition> sortedtracklist = tracklist.OrderByDescending(s => s.getStyle() == style).ToList();
            return sortedtracklist;
        }

        public string findByRange(double first, double last) // находит треки, продолжительность которых удовлетворяет диапазону введенному, затем возвращает строку, переделанную с помощью makeStr()
        {
            string str = "";
            double m_len = 0;
            for (int i = 0; i < tracklist.Count(); i++)
            {
                m_len = tracklist[i].getMusic_length();
                if ( m_len >= first && m_len <= last)
                {
                    str+= tracklist[i].makeStr() + " ";
                }
            }
            return str;
        }
    }
}
