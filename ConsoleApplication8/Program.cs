using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Леон
{

    public class bank
    {
        public string name;
        public List<int> list1 = new List<int>();
        public List<int> list2 = new List<int>();
        public List<int> list3 = new List<int>();

        public bank(string name)
        {
            this.name = name;
            string h;
            Console.WriteLine("введите тарифы на жилье:");

            while ((h = (Console.ReadLine())) != "0")
            {
                list1.Add(Math.Abs(Convert.ToInt16(h)));
            }
            Console.Clear();
            Console.WriteLine("введите тарифы на авто:");
            while ((h = (Console.ReadLine())) != "0")
            {
                list2.Add(Math.Abs(Convert.ToInt16(h)));
            }
            Console.Clear();
            Console.WriteLine("введите тарифы на отдых:");
            while ((h = (Console.ReadLine())) != "0")
            {
                list3.Add(Math.Abs(Convert.ToInt16(h)));
            }
            Console.Clear();

        }
        public void spisok()
        {
            Console.WriteLine("тарифы на жилье:");
            foreach (var y in list1)
            {
                Console.Write(y);
            }
            Console.WriteLine("тарифы на авто:");
            foreach (var y in list2)
            {
                Console.Write(y);
            }
            Console.WriteLine("тарифы на отдых:");
            foreach (var y in list3)
            {
                Console.Write(y);
            }



        }
    }





    class credit
    {


        string men;
        int min;
        public string target
        {
            
            set
            {
                Regex x = new Regex(@"дом|авто|отдых");
                MatchCollection matches = x.Matches(value);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        men += match;
                        break;
                    }
                }
                else
                {
                    men = "Совпадений не найдено";
                }
            }
            get { return men; }
        }

        public void credit1(bank a, int price, string h)
        {
            this.men = h;
            if (this.men == "дом")
            {
                if (price > a.list1.Max())
                {
                    min = a.list1.Max();

                }
                else
                {
                    min = a.list1.Min();
                }
                Console.WriteLine("оптимальный кредит" + min);


            }
            if (this.men == "авто")
            {
                if (price > a.list2.Max())
                {
                    min = a.list2.Max();

                }
                else
                {
                    min = a.list2.Min();
                }
                Console.WriteLine("оптимальный кредит" + min);


            }
            if (this.men == "отдых")
            {
                if (price > a.list3.Max())
                {
                    min = a.list3.Max();

                }
                else
                {
                    min = a.list3.Min();
                }
                Console.WriteLine("оптимальный кредит" + min);


            }
        }
        public credit()
        {
            
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                Console.WriteLine("введите количество банков");
                int n = Convert.ToInt32(Console.ReadLine());
                bank[] a = new bank[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Clear();
                    Console.WriteLine("введите назваие банка");
                    a[i] = new bank(Console.ReadLine());
                }
                Console.Clear();
                Console.WriteLine("введите номер банка от 0 до " + n);
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("сумму кредита");
                int kl = Convert.ToInt32(Console.ReadLine());
                    credit ar = new credit();
                ar.credit1(a[n], kl, Console.ReadLine());
            }
            Console.ReadLine();


        }
    }
}
