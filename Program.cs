using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans;
            double x = 0, y = 0, z = 0;
            bool again = true;


            // do-while loop version
            //do
            //{
            //    Console.WriteLine("Enter Length");
            //    var length = double.TryParse(Console.ReadLine(), out x);

            //    Console.WriteLine("Enter Width");
            //    var width = double.TryParse(Console.ReadLine(), out y);

            //    var area = x * y;
            //    var per = 2 * x + 2 * y;

            //    Console.WriteLine($"Area: {area}");
            //    Console.WriteLine($"Perimeter {per}");

            //    Console.WriteLine("Do you want to go again y/n ?");
            //    ans = Console.ReadLine().ToLower();
            //} while (ans == "y");


            //while loop version

            while (again)
            {
                Console.WriteLine("Enter Length");
                var length = double.TryParse(Console.ReadLine(), out x);

                Console.WriteLine("Enter width");
                var width = double.TryParse(Console.ReadLine(), out y);

                Console.WriteLine("Enter Height");
                var height = double.TryParse(Console.ReadLine(), out z);

                var area = x * y;
                var per = 2 * x + 2 * y;
                var vol = x * y * z;

                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter {per}");
                Console.WriteLine($"Volume: {vol}");

                Console.WriteLine("Do you want to go again y/n ?");
                ans = Console.ReadLine().ToLower();


                if (ans == "n")
                {
                    Console.WriteLine("Goodbye");
                    again = false;
                }
                else
                {
                    again = true;
                }
            }


            //Console.WriteLine("Hello World!");
        }
    }
}
