using System;
using System.Collections.Generic;

namespace Linst_Lern
{

     class Cafedra
    {
        List<Cafedra> lists = new List<Cafedra>();

        public string Name { get; set; }
        public string Famil { get; set; }
        public string Fathername { get; set; }
        public string Work { get; set; }
        public int Level { get; set; }
        public int Hardly { get; set; }


        public void Output()
        {
            foreach (Cafedra listss in lists)
            {
                Console.WriteLine("Name empoyees: " + listss.Name + "\nSurname empoyees: " + listss.Famil + "\nPatronymic empoyees: " + listss.Fathername + "\nPosition empoyees: " + listss.Work + "\nAcademic degree of empoyees: " + listss.Level + "\nLoad of empoyees: " + listss.Hardly);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        
        public void Print()
        {
            Console.WriteLine("Print name employees: ");
            string name = Console.ReadLine();

            Console.WriteLine("Print surname employees: ");
            string famil = Console.ReadLine();

            Console.WriteLine("Print patronymic employees: ");
            string fathername = Console.ReadLine();

            Console.WriteLine("Print position employees: ");
            string work = Console.ReadLine();
            int level;
            while (true)
            {
                Console.WriteLine("Print academic degree employees: ");
                string input = Console.ReadLine();
                bool IntValidate = Int32.TryParse(input, out int number);
                if (!IntValidate)
                {
                    Console.WriteLine("It's not number, print again.");
                }
                else
                {
                    if (number != 0)
                    {
                        level = Convert.ToInt32(input);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Print number!");
                    }
                }
            }
            int hardly;
            while (true)
            {
                Console.WriteLine("Print load employees: ");
                string input = Console.ReadLine();
                bool IntValidate = Int32.TryParse(input, out int number);
                if (!IntValidate)
                {
                    Console.WriteLine("It's not number, print again.");
                }
                else
                {
                    if (number != 0)
                    {
                        hardly = Convert.ToInt32(input);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Print number!");
                    }
                }
            }
            lists.Add(new Cafedra() { Name = name, Famil = famil, Fathername = fathername, Work = work, Level = level, Hardly = hardly });
        }
    }


    class Program
    {
        static void Main()
        {

            Cafedra ad = new Cafedra();
            do
            {
              Console.WriteLine("[1]. Print information about employees.\n[2]. Output information about employees.\n[3]. Exit.");
               int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        int kol;
                        Console.WriteLine("Please, print number of employees to save information to the database: "); kol = Convert.ToInt32(Console.ReadLine());
                        for (int qqq = 0; qqq < kol; qqq++)
                        {
                          ad.Print();
                        }
                        break;
                    case 2:
                        ad.Output();
                        break;                  
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ошибка.");
                        break;
                }    }  while(true);
        }
    }
}
