using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peredelanaya_Laba_2_3var
{
    public class Paper
    {
        //private string v;
        //private DateTime dateTime;

        public string Nazvanie { get; set; }
        public Person Avtor { get; set; }
        public DateTime Data { get; set; }
        //public string? Publication { get; internal set; }
        //public object Time { get; internal set; }

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
            Data = new DateTime(2015, 7, 20, 18, 20, 25);

            Nazvanie = "Космический нинздя";
            Avtor = new("Тот самый");
            Data = new DateTime(2017, 6, 20, 18, 30, 25);

            Nazvanie = "Гидротрансформатор";
            Avtor = new("Клим Саныч");
            Data = new DateTime(2016, 7, 20, 11, 30, 25);
        }

        //public Paper(string v, DateTime dateTime)
        //{
        //    this.V = v;
        //    this.DateTime = dateTime;
        //}
        //public string V;

        //public DateTime DateTime;

        public override string ToString()
        {
            return Nazvanie + ' ' + Avtor + ' ' + Data.ToString("dd.mm.yyyy");
        }

        public string ToFullString()
        {
            return $"{Nazvanie} {Avtor} - Дата публикации: {Data}";
        }
    }
}
