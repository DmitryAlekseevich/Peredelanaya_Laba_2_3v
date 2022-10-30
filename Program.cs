using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.IO;


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
            Avtor = new("Великий","неподкупный");
            Data = new DateTime(9,06, 1);
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
            //_prodoljitelnost = new TimeFrame(2018, 09, 01, 8, 30, 01);           
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
               // return string.Join(",", Papers.Select(p => p.Publication)); //возвращает ссылку на публикацию с самой поздней датой выхода           
                {
                    return null;
                }
            }
        }
        public void AddPapers(params Paper[] papers)
        {
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
