using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    enum names
    {
        varun,
        sai,
        venkata
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            //enums
            names myVar =names.varun;
            Console.WriteLine(myVar);
            //strings
            string fname = "varun";
            string lname = "sai";
            Console.WriteLine(fname+lname);
            //concatenastion
            int myInt = 1;
            double myDouble = 6.890;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));   
            Console.WriteLine(Convert.ToDouble(myInt));    
            Console.WriteLine(Convert.ToInt32(myDouble));  
            Console.WriteLine(Convert.ToString(myBool));
            //user inputs
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            //boolean
            Console.WriteLine(10 > 9);
            //switch
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 30: Console.WriteLine("It is 30"); 
                    break;
                case 40: Console.WriteLine("It is 40");
                    break;
                case 50: Console.WriteLine("It is 50");
                    break;
                default: Console.WriteLine("Not 30, 40 or 50"); 
                    break;
            }

            
        }
    }
}
