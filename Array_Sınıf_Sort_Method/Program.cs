using System;
namespace Array_Indexof
{
    class Program
    {
        static void Main(string[] args)
        {
            Array isimler = new[]{"hilmi","hüseyin","ali","veli","ahmet"};
            for(int i=0;i<isimler.Length;i++)
            {
                System.Console.WriteLine(isimler.GetValue(i));

                Array.Sort(isimler);
                System.Console.WriteLine("***************");

                for(int a=0;a<isimler.Length;a++)
                {
                    System.Console.WriteLine(isimler.GetValue(i));
                }
            }
        }
    }
}