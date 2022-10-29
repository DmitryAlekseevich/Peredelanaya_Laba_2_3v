using System;
using System.Text;

namespace Peredelanaya_Laba_2_3v

{
    class Program
    {
        private static void Main()
        {
            ResearchTeam researchTeam = new();
            Console.WriteLine(researchTeam.ToFullString());
        }
    }
    public enum TimeFrame { Year, TwoYears, Long }

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
        public string Nazvanie { get; } 
        public Person Avtor { get; }
        public DateTime Data { get; }

        public Paper(string nazvanie, Person avtor, DateTime data)
        {
            Nazvanie = nazvanie;
            Avtor = avtor;
            Data = data;
        }
        public Paper()
        {
            Nazvanie = "ООО Колобок";
            Avtor = new("Великий неподкупный");
            Data = 29.06.2000;
        }
        public string ToFullString()
        {
            return $"{Nazvanie.Surname} {Avtor.Name} - {Title}. Дата публикации: {Data}";
        }
    }
    public class ResearchTeam
    {
        private readonly string _nazvanieisled;
        private readonly string _nazvanieorg;
        private readonly int _regnomer;
        private readonly TimeFrame _prodoljitelnost;
        private readonly Paper[] _papers;
      
        public ResearchTeam(string nazvanieisled, string nazvanieorg, int regnomer, TimeFrame prodoljitelnost)
        {
            _nazvanieisled = nazvanieisled;
            _nazvanieorg = nazvanieorg;
            _regnomer = regnomer;
            _prodoljitelnost = prodoljitelnost;
            
        }
        public ResearchTeam()
        {
            _nazvanieisled = "Ленин был грибом";
            _nazvanieorg = "Загадка жака фрески";
            _regnomer = 1;
            _prodoljitelnost = new TimeFrame (10-20);
            _papers = new[] { new Paper() };
        }
        public string NazvanieISL => _nazvanieisled;
        public string NazvanieORG => _nazvanieorg;
        public int Regnomer => _regnomer;
        public TimeFrame Prodoljitelnost => _prodoljitelnost;
        public Paper[] Papers => _papers;
        public Paper? MiddleRating
        {
            get
            {
                if (_papers is null)
                {
                    return null;
                }
                return _papers.Sum(x => x.Data) / _papers.Length; //дата публикации
            }
        }
        public void AddArticles(params Paper[] papers)
        {
            _papers = papers;
        }
        public string ToFullString(bool isArticles = true)
        {
            return $"Название темы исследования: {NazvanieISL}\n Название организации: {NazvanieORG}\n Номер регистрации " +
                $"{Regnomer}\n Продолжительность иследования: {Prodoljitelnost.ToString()}";

        }
        public string ToShortString()
        {
            return $"{ToFullString(false)}\n";
               
        }
    }
}
