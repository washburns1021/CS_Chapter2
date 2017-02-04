using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 690;
            int hours = 690 / 60;



            minutes = minutes - (hours * 60);
       
            Console.WriteLine("Hours " + hours + "Minutes" + minutes);
        }           
    }
}
