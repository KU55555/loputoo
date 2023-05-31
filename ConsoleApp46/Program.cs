using ConsoleApp46;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static string wrightpath = "C:/Users/opilane/Desktop/FileToDesktop.txt";
        private static string wrongPath = "V:/Users/opilane/FileToDesktop.txt";
        static void Main(string[] args)
        {
            
           
            Console.Title = "Loputoo";
            Console.WriteLine("Loputoo");

            Console.WriteLine("\n1. SkipWhile");
            Console.WriteLine("2. EmptyRangeRepeat");
            Console.WriteLine("3. Õige - teeb faili Vale - ei tee faili");
            Console.WriteLine("4. Triangle.");
         
            string shape = Console.ReadLine();
          
            switch (shape)
            {
                case "SkipWhile":
                    SkipWhile();
                    break;

                case "EmptyRangeRepeat":
                    EmptyRangeRepeat();
                    break;

                case "Triangle":
                    Triangle();
                    break;

                case "Õige":
                    Õige();                  
                    break;

                case "Vale":
                    Vale();
                    break;

                default:
                    Console.WriteLine("\nVale. Valikut ei tehtud.");
                    break;
            }
            Console.ReadKey();
            
        }

        public static void SkipWhile()
        {
            Console.WriteLine("----------SkipWhile--------------");    
            var skipWhile = PeopleList.peoples.SkipWhile(s => s.Name.Length > 4);

            foreach (var item in skipWhile)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void EmptyRangeRepeat()
        {
            
            Console.WriteLine("EmptyRangeRepeat LINQ");

            var emptyColletion1 = Enumerable.Empty<string>();
            var emptyColletion2 = Enumerable.Empty<People>();

            Console.WriteLine("Type {0}" + emptyColletion1.GetType().Name);
            Console.WriteLine("Count: {0} " + emptyColletion1.Count());

            Console.WriteLine("Type {0}" + emptyColletion2.GetType().Name);
            Console.WriteLine("Count: {0} " + emptyColletion2.Count());

            var intCollection = Enumerable.Range(3, 9);
            Console.WriteLine("Total count: {0} ", intCollection.Count());

            for (int i = 0; i < intCollection.Count(); i++)
            {
                Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i));
            }

            var repeatCollection = Enumerable.Range(3, 9);
            Console.WriteLine("Total count: {0} ", intCollection.Count());

            for (int i = 0; i < repeatCollection.Count(); i++)
            {
                Console.WriteLine("Value at index {0} : {1}", i, repeatCollection.ElementAt(i));
            }

        }

        private static void Triangle()
        {
            Console.WriteLine("\nSisesta number 3");

            double length = double.Parse(Console.ReadLine());

            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length * 2 - 1; column++)
                {
                    string mark = " ";

                    if (row == length)
                    {
                        mark = "1";
                    }
                    else if (row + column >= length + 1 && column - length + 1 <= row)
                    {
                        mark = "2";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }

        private static void Õige()
        {
            string inputText = Console.ReadLine();
            File.WriteAllText(wrightpath, inputText);

            Console.WriteLine("Salvestas edukalt desktopile");

        }
    
        private static void Vale()
        {
            {
                try
                {
                    string inputText = Console.ReadLine();
                    File.WriteAllText(wrongPath, inputText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ei salevstanud desktopile file kuna " +
                        "seda urli ei ole");
                    Console.WriteLine(ex.Message);
                }
            }
        }
    
    }
}
