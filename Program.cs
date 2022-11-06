using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Peredelanaya_Laba_2_3v

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            ResearchTeam team = new ResearchTeam();
            Paper[] papers = new Paper[2];
            papers[0] = new Paper("Космический нинздя", new DateTime(1887, 6, 1));
            papers[1] = new Paper("ООО Колобок", new DateTime(1889, 8, 21));
            team.AddPapers(papers);

            foreach (Paper paper in team.list)
            {
                Console.WriteLine(paper.Publication);
                //Console.WriteLine(paper.Time.ToShortDateString());
            }


            Console.WriteLine(team.ToString());

            Console.ReadKey();
            //ResearchTeam researchTeam = new();
            //Console.WriteLine(researchTeam.ToFullString());

            //todo:дописать мейн
            /*
             • Присвоить значения всем определенным в типе ResearchTeam свойствам, преобразовать данные в текстовый вид с помощью метода ToString() и вывести данные.
• С помощью метода AddPapers (params Paper []) добавить элементы в список публикаций и вывести данные объекта ResearchTeam.
• Вывести значение свойства, которое возвращает ссылку на публикацию с самой поздней датой выхода;

             */
        }
    }
    public enum TimeFrame { Год, Двагода, Долго }

    public class Person
    {
        public string Name { get; }
        public string Surname { get; }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string FullName => $"{Surname} {Name}";

    }
    public class Paper
    {
        private string v;
        private DateTime dateTime;

        public string Nazvanie { get; set; }
        public string Avtor { get; set; }
        public DateTime Data { get; set; }
        public string? Publication { get; internal set; }
        public object Time { get; internal set; }

        public Paper(string nazvanie, string avtor, DateTime data)
        {
            Nazvanie = nazvanie;
            Avtor = avtor;
            Data = data;
        }
        public Paper()
        {
            Nazvanie = "ООО Колобок";
            Avtor = new("Великий неподкупный");
            Data = new DateTime(2015, 7, 20, 18, 20, 25);

            Nazvanie = "Космический нинздя";
            Avtor = new("Тот самый");
            Data = new DateTime(2017, 6, 20, 18, 30, 25);

            Nazvanie = "Гидротрансформатор";
            Avtor = new("Клим Саныч");
            Data = new DateTime(2016, 7, 20, 11, 30, 25);
        }

        public Paper(string v, DateTime dateTime)
        {
            this.V = v;
            this.DateTime = dateTime;
        }
        public string V;

        public DateTime DateTime;

        public override string ToString()
        {
            return Nazvanie + ' ' + Avtor + ' '  + Data.ToString("dd.mm.yyyy");
        }

        public string ToFullString()
        {
            return $"{Nazvanie} {Avtor} - Дата публикации: {Data}";
        }
    }
    public class ResearchTeam
    {
        private readonly string _nazvanieisled;
        private readonly string _nazvanieorg;
        private readonly int _regnomer;
        private readonly TimeFrame _prodoljitelnost;
        private readonly Paper[] _papers;

        //private Paper[] _papers;


        private List<Paper> Papers = new List<Paper>() { new Paper("pub_1", new DateTime(1881, 6, 2)), new Paper("pub_2", new DateTime(1883, 6, 2)), new Paper("pub_3", new DateTime(1885, 6, 2)) };
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


        public List<Paper> list
        {
            get { return Papers; }

            set { Papers = value; }
        }

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

            //int length = _papers.Length + papers.Length;
            //Paper[] newPapers = new Paper[length];
            //for (int i = 0; i < _papers.Length; i++)
            //{
            //    newPapers[i] = _papers[i];
            //}
            //for (int i = _papers.Length; i < papers.Length; i++)
            //{
            //    newPapers[i] = papers[i];
            //}
            //_papers = newPapers;
        }

        public override string ToString()
        {
            return $"Название темы исследования: {NazvanieISL}\n Название организации: {NazvanieORG}\n Номер регистрации " +
                 $"{Regnomer}\n Продолжительность иследования: {Prodoljitelnost.ToString()}";

            return string.Join(",", Papers.Select(p => p.Publication));
        }

        public string ToFullString(bool isArticles = true)
        {
            return $" Название темы исследования: {NazvanieISL}\n Название организации: {NazvanieORG}\n Номер регистрации " +
                $"{Regnomer}\n Продолжительность иследования: {Prodoljitelnost.ToString()}";

        }

        //public string ToShortString()
        //{
        //    return $"{ToFullString(false)}\n";
        //}
    }
}
