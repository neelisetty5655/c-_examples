using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_3
{
    public class Program
    {
       /* public void reset()
        { 
            dynamic username, password;
            Console.WriteLine("enter your user name:");
           username =Console.ReadLine();
           Console.WriteLine("enter new password:");
           password =Convert.ToInt32(Console.ReadLine());
            

        }*/
        IDictionary<int, string> useripass = new Dictionary<int, string>();
        IDictionary<int, string> userie = new Dictionary<int, string>();
        IDictionary<int, int> userip = new Dictionary<int, int>();
        static void Main(string[] args)
        {
         // IDictionary<int,string> useripass = new Dictionary<int,string>();
            //IDictionary<int,string> userie = new Dictionary<int, string>();
           // IDictionary<int, int> userip= new Dictionary<int, int>();
           Program obj=new Program();
            string[] alpha = new string [] {"a","b","c","d","e","f", "g" ,"h", "i" ,"j", "k" ,"l", "m", "n", "o", "p", "q", "r", "s" , "t", "u" ,"v", "w", "x", "y","z","1","2","3","4","5","6","7","8","9","0","_","@","$","&"};
            dynamic username=0, phoneno, pass,flag=0,op=" ",email,p1=0,p2=0,p3=0,p4=0,p5=0,p6=0,p7=0,p8=0;
            //while loop start
            while (op!= "l")
            {
                Console.WriteLine("u want to signin or signup(i/u):");
                op = Console.ReadLine();
                if (op == "u")
                {
                    Console.WriteLine("enter your email:");
                    email = Console.ReadLine();
                    Console.WriteLine("enter your phone no:");
                    phoneno = Convert.ToInt32(Console.ReadLine());
                    username = phoneno;
                    obj.userip.Add(username, phoneno);
                    obj.userie.Add(username, email);
                    Random random = new Random();
                    p1 = random.Next(alpha.Length);
                    p2 = random.Next(alpha.Length);
                    p3 = random.Next(alpha.Length);
                    p4 = random.Next(alpha.Length);
                    p5 = random.Next(alpha.Length);
                    p6 = random.Next(alpha.Length);
                    p7 = random.Next(alpha.Length);
                    p8 = random.Next(alpha.Length);

                    pass = alpha[p1] + alpha[p2] + alpha[p3] + alpha[p4] + alpha[p5] + alpha[p6] + alpha[p7] + alpha[p8];
                    StringBuilder sb = new StringBuilder();
                    sb.Append(pass);
                    Console.WriteLine($"your password is:{sb}");
                    obj.useripass.Add(username, sb.ToString());
                Console.WriteLine("******account creation is sucess*****");
                }
                else
                {
                    Console.WriteLine("enter your user name:");
                    username= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter your user password:");
                    pass = Console.ReadLine();
                    //for loop strat
                 foreach(var i in obj.useripass)
                    {
                        if(i.Key==username && i.Value==pass)
                        {
                            flag++;
                            break;
                        }
                    }
                 //for loop end
                 if(flag>0)
                    {
                        Console.WriteLine("***login success***");

                        //obj.reset();
                    }
                    else
                    {
                        Console.WriteLine("!!!login failed!!!");
                       
                    }
                }

            }
            //while loop end
        }
    }
}
