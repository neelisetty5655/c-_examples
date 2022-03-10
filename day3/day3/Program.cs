using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class Program
    {
        int id;
        String name;
        public Program()
        {
            Console.WriteLine("HELLO WORLD");
        }
        static void Main(string[] args)
        {
            Program s1 = new Program();    
            s1.id = 101;
            s1.name = "VARUNSAI";
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name);
            Program e1 = new Program();
            Program e2 = new Program();
            //array list start
            /*  ArrayList arrlist=new ArrayList();
              int i = 0,n;
              int[] arr=new int[5];
              for(i=0;i<5;i++)
              {
                  n=Convert.ToInt32(Console.ReadLine());
                  arr[i] = n;
              }

              arrlist.AddRange(arr);
              for( i=0;i<arrlist.Count;i++)
              Console.WriteLine(arrlist[i]);

              Queue q=new Queue();
              q.Enqueue("v");
              q.Enqueue("a");
              q.Enqueue("r");
              arrlist.AddRange(q);
              for (i = 0; i < arrlist.Count; i++)
                  Console.WriteLine(arrlist[i]);*/

            //array list end


            //list start
            /*var numbers=new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            Console.WriteLine(numbers.Count);
           int[] arr = {1,2,3,4,4,5};
            numbers.AddRange(arr);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }


                dynamic name, id,op;
                Console.WriteLine("enter your name:");
                name = Console.ReadLine();
                Console.WriteLine("enter your id:");
                id = Convert.ToInt32(Console.ReadLine());
                var customers = new List<Customer>()
            {
                new Customer(){Id=id,fname=name}
            };
                foreach (Customer customer in customers)
                {
                    Console.WriteLine(customer.fname);
                    Console.WriteLine(customer.Id);
                }
            Console.WriteLine("you want to edit(y/n)");
            op=Console.ReadLine();
            if(op=="y")
            {
                Console.WriteLine("enter updated name:");
                customers[0].fname = Console.ReadLine();
                Console.WriteLine("enter updated id:");
                customers[0].Id= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("UPDATED DATA:");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.fname);
                Console.WriteLine(customer.Id);
            }
            */
            //list end

            //SORTED LIST
            /* SortedList<int,string> list = new SortedList<int,string>();
             list.Add(1,"varun");
             list.Add(2, "sai");
             foreach(var i in list )
             {
                 Console.WriteLine(i.Key+i.Value);
             }
             //SORTED LIST END
             Dtstation<int> dtstation = new Dtstation<int>();
             dtstation.Trans = 1000;
             keyvalue<string, string> kv = new keyvalue<string, string>();
             kv.Key = "id";
             kv.Value = "1";
             Console.WriteLine(kv.Key + kv.Value);*/



        }
        public class Customer
        {
            public int Id { get; set; }
            public string fname { get; set; }
        }
        class Dtstation<T>
        {
            public T Trans { get; set; }
        }
        class keyvalue<Tkey, Tvalue>
        {
            public string Key { get; set; }
            public Tvalue Value { get; set; }
        }
        class customer<Tid, Tfrom, Tto>
        {
            public int ID { get; set; }
            public int F { get; set; }
            public int T { get; set; }

        }
        /* public interface userdata
     {
         void data();
     }
     public interface premium
     {
         void premiumamount();
     }
     public class displaypremium:premium
     {
         public void premiumamount()
         {
             persondata obj = new persondata();

             if(obj.age<20)
             {
                 Console.WriteLine("your premium amount is 10000");

             }
             else if(obj.age>=20 && obj.age<=30)
             {
                 Console.WriteLine("your premium amount is 20000");
             }
             else
             {
                 Console.WriteLine("your premium amount is 30000");
             }
         }
     }
     public class persondata:userdata
     {
         public int age;
         public string name;
         public dynamic dob;
         public void data()
         {
             Console.WriteLine("enter your age:");
             age=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter your dob:");
             dob =Console.ReadLine();
             Console.WriteLine("enter your name:");
             name =Console.ReadLine();


         }
     }*/
    }
}
