using System;
namespace Denemeler
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Kendi Çarpım Tablomuzu Yapalım");
            System.Console.WriteLine("İlk Değerimizi Girelim");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("İkinci Değerimizi Girelim");
            int b = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Girilen Değerlerimiz : {0,0} {1,0} {2,0}",a,"ve",b);
            

            for(int i=a;i<=b;i++)
            {   
                
                System.Console.WriteLine("{0,3} {1,0} {2,0} {3,0} {4,0}",i,"x",i,"=",i*i);
                 }
        }
    }
}