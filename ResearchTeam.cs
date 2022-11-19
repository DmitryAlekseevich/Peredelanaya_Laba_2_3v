using Peredelanaya_Laba_2_3v;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peredelanaya_Laba_2_3var
{


    public class ResearchTeam
    {
        private readonly string _nazvanieisled;
        private readonly string _nazvanieorg;
        private readonly int _regnomer;
        private readonly TimeFrame _prodoljitelnost;
        private readonly Paper[] _papers;

        private Paper[] _papers;


        //private List<Paper> Papers = new List<Paper>() { new Paper("pub_1", new DateTime(1881, 6, 2)), new Paper("pub_2", new DateTime(1883, 6, 2)), new Paper("pub_3", new DateTime(1885, 6, 2)) };
        public ResearchTeam(string nazvanieisled, string nazvanieorg, int regnomer, TimeFrame prodoljitelnost)
        {
            _nazvanieisled = nazvanieisled;
            _nazvanieorg = nazvanieorg;
            _regnomer = regnomer;
            _prodoljitelnost = prodoljitelnost;

        }

        public ResearchTeam()
        {
            _nazvanieisled = "Ленин был грибом?!";
            _nazvanieorg = "Загадка жака фрески ";
            _regnomer = 288;
            _prodoljitelnost = TimeFrame.Двагода;
            _papers = new[] { new Paper() };

        }

        public string NazvanieISL => _nazvanieisled;
        public string NazvanieORG => _nazvanieorg;
        public int Regnomer => _regnomer;
        public TimeFrame Prodoljitelnost => _prodoljitelnost;


        //public List<Paper> list
        //{
        //    get { return Papers; }

        //    set { Papers = value; }
        //}

        //public Paper Papers => _papers is null ? null : _papers.OrderBy(x => x.Data).Last(); 

        //нужно свойство типа Paper ( только с методом get), которое возвращает ссылку на публикацию с самой поздней датой выхода; если список публикаций пустой, свойство возвращает значение null;

        //public double Paper
        //{
        //    get
        //    {
        //        return string.Join(",", Papers.Select(i => i.Publication)); //возвращает ссылку на публикацию с самой поздней датой выхода           
        //        {
        //            return 0;
        //        }
        //    }
        //}

        public void AddPapers(params Paper[] papers) // метод для добавления элементов в список публикации
        {
            Papers.AddRange(papers);

            int length = _papers.Length + papers.Length;
            Paper[] newPapers = new Paper[length];
            for (int i = 0; i < _papers.Length; i++)
            {
                newPapers[i] = _papers[i];
            }
            for (int i = _papers.Length; i < papers.Length; i++)
            {
                newPapers[i] = papers[i];
            }
            papers = newPapers;
        }

        public override string ToString()
        {
            return $"Название темы исследования: {NazvanieISL}\n Название организации: {NazvanieORG}\n Номер регистрации " +
                 $"{Regnomer}\n Продолжительность иследования: {Prodoljitelnost.ToString()}";

            return string.Join(",", Papers.Select(p => p.Publication));
        }

        //    public string ToFullString(bool isArticles = true)
        //    {
        //        return $" Название темы исследования: {NazvanieISL}\n Название организации: {NazvanieORG}\n Номер регистрации " +
        //            $"{Regnomer}\n Продолжительность иследования: {Prodoljitelnost.ToString()}";

        //    }

        //    public string ToShortString()
        //    {
        //        return $"{ToFullString(false)}\n";
        //    }

    }
}
