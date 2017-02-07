using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program shows the number of eggs produced by 4 chickens.");//

            int num1;

            Console.WriteLine("Enter the Egg Number for Chicken 1: ");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chicken 1 Layed {0} Eggs", num1);



            int num2;

            Console.WriteLine("Enter the Egg Number for Chicken 2: ");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chicken 2 Layed {0} Eggs", num1);



            int num3;

            Console.WriteLine("Enter the Egg Number for Chicken 3: ");

            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chicken 3 Layed {0} Eggs", num3);



            int num4;

            Console.WriteLine("Enter the Egg Number for Chicken 4: ");

            num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chicken 4 Layed {0} Eggs", num4);



            int total = num1 + num2 + num3 + num4;



            Console.WriteLine("The Total Egg count is {0}", total);

            int dozen = 12;



            int totaldoz = (num1 + num2 + num3 + num4) / dozen;

            int remainder = total % dozen;

            Console.WriteLine("The Total Dozens of eggs is {0} with {1} extra", totaldoz, remainder);
        }
    }
}
