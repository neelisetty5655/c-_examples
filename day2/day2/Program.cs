using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    public class Program
    {

        static void Main(string[] args)
        {

            //interface
            /*  userdata d;
              d = new persondata();
              d.data();
              premium p;
              p = new displaypremium();
              p.premiumamount();
            */
            /* string name,gender,o,search;
             int m=0, f=0,i=0;
             string[] male=new string[5];
             string[] female=new string[5];
          while(i==0)
             {
                 Console.WriteLine("enter person name:");
                 name=Console.ReadLine();
                 Console.WriteLine("enter person gender(m/f):");
                 gender=Console.ReadLine();  
                 if(gender=="f")
                 {
                     female[f] = name;
                     f++;
                 }
                 else
                 {
                     male[m] = name;
                     m++;
                 }
                 Console.WriteLine("you wanto enter data(y/n):");
                 o=Console.ReadLine();
                 if(o=="y")
                 {
                     i = 0;
                 }
                 else{
                     i = 1;
                 }
             }
             Console.WriteLine("males list:");
             for(int j=0;j<=m;j++)
             {
                 Console.WriteLine(male[j]);
             }
             Console.WriteLine("female list:");
             for (int j = 0; j <= f; j++)
             {
                 Console.WriteLine(female[j]);
             }
             Console.WriteLine("enter name of the person :");
             search=Console.ReadLine();*/

            //jagged array start

            int[] arr = new int[5];
             int[][] jagged=new int[2][];
             int n,i,j=0;
             while(j<2)
             {
                 for (i = 0; i <5; i++)
                 {
                     n = Convert.ToInt32(Console.ReadLine());
                     arr[i] = n;
                 }
                 jagged[j]=new int[5];
                  for(i=0; i <5; i++)
                 {
                     jagged[j][i]=arr[i];
                 }
                 j++;
             }
             for(i=0; i<2; i++)
             {
                 for(j=0; j<jagged[i].Length; j++)
                 {
                     Console.WriteLine(jagged[i][j]);
                 }
             }

            //jaggedarray end


            

          

            
           




            //************dictionary start**********
            /* IDictionary<int,string> data = new Dictionary<int,string>();
             data.Add(1, "varun");
             data.Add(2, "sai");
             foreach(var i in data)
             {
                 Console.WriteLine(i.Key+i.Value);
             }
          
            */
            //************dictionary end************
            //date and time formats
            DateTime day1 = new DateTime();

          
            DateTime day2 = new DateTime(2018, 15, 11);

          
            DateTime day3 = new DateTime(2025, 22, 21, 15, 20, 10);

            
            DateTime day4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine(day1);
            Console.WriteLine(day2);
            Console.WriteLine(day3);
            Console.WriteLine(day4);
            //string builder
            StringBuilder sb = new StringBuilder();
            sb.Append("varunsai");
            Console.WriteLine(sb.ToString());


        }



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
