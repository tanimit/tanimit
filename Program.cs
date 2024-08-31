using System;
using System.Runtime.InteropServices.Marshalling;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your result :");
         int result=int.Parse(Console.ReadLine());
         if(result>=80)
         {
            Console.WriteLine("A+");
         }
         else if(result>=70)
         {
         Console.WriteLine("A-");
         }
         else if(result>=60)
         {
            Console.WriteLine("B");
         }
         else if(result>=50)
         {
            Console.WriteLine("B-");
         }
         else if(result>=40)
        {
            Console.WriteLine("C");
        }
         else if(result>=33)
         {
           Console.WriteLine("D");
         }
         else
         {
            Console.WriteLine("Fail");
         }

    }
}
