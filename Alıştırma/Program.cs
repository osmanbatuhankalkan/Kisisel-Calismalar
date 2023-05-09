using System;

namespace Alıstırma
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bölünecek sayıyı giriniz");
            int a = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Bölen sayıyı giriniz");
            int b = int.Parse(Console.ReadLine());

            int c;

            if(a%b==0)
            {
                System.Console.WriteLine("{0,0} {1,0} {2,0} sayısına",a,"tam bölünür",b);
            }
            else
                System.Console.WriteLine("{0,0} {1,0} {2,0} sayısına",a,"tam bölünmez",b);
        } 
    }
}