using System;
namespace deneme
{
    class program
    {
        static void Main(string[] args)
        {   System.Console.WriteLine("Lütfen Kaçtan geriye saymak istiyorsanız bir değer giriniz.....");
            int a = int.Parse(Console.ReadLine());
            while(a>=0)
            {   
                System.Console.WriteLine(a);
                a--;
            }
        }
    }
}