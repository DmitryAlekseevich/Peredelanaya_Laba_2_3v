using System;
using System.Collections.Generic;

namespace Peredelanaya_Laba_2_3v

{
    class Program
    {
        private static void Main()
        {
            ResearchTeam researchTeam = new();
            Console.WriteLine(researchTeam.ToFullString());

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
            Avtor = new("Великий", "неподкупный");
            Data = new DateTime(9, 06, 1);
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
        public Paper[] Papers => _papers;
        //todo: нужно свойство типа Paper ( только с методом get), которое возвращает ссылку на публикацию с самой поздней датой выхода; если список публикаций пустой, свойство возвращает значение null;

        //public double MiddleRating
        //{
        //    get
        //    {              
        //       // return string.Join(",", Papers.Select(p => p.Publication)); //возвращает ссылку на публикацию с самой поздней датой выхода           
        //        {

        //            return 0;
        //        }
        //    }
        //}
        public void AddPapers(params Paper[] papers)
        {
            //todo: добавление статей не равно замена массив, нужно расширить старый (выделить новый блок памяти) размером = старый массив + новый, затем скопировать элементы старого и потом нового

            papers = papers;
        }
        public string ToFullString(bool isArticles = true)
        {
            return $" Название темы исследования: {NazvanieISL}\n Название организации: {NazvanieORG}\n Номер регистрации " +
                $"{Regnomer}\n Продолжительность иследования: {Prodoljitelnost.ToString()}";

        }
        public string ToShortString()
        {
            return $"{ToFullString(false)}\n";
        }
    }
}
