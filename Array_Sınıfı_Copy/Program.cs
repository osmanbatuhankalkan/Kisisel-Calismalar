using System;
namespace Array_copy
{
    class Program
    {
        static void Main(string[] args)
        {
            //öncelikle klonlamakla, kopyalamak arasındaki farkı iyi anlamak lazım.
            //klon var olan bir şeyden 1 ken 2 tane olması bize öğretilen ilk klon "dolly" gibi 
            //kopyalamak ise elimizde 1 lt su var bunu 0,5 lik 2 bardağa böldük
            //Elimizdeki bir dizinin verilerini bir başka dizite kopyalamamızı sağlayan bir fonksiyondur
            Array isimler = new[]{"ali","veli","cengiz","ahmet","mehmet"};
            string[] isimler2 = new string[isimler.Length];
            string[] isimler3 = new string[isimler.Length];

            //Array.Copy(isimler, isimler2,5); 

            //for(int i=0;i<isimler2.Length;i++)
            //{
              //  System.Console.WriteLine(isimler2[i]);
            //}

            Array.Copy(isimler,2,isimler3,3,2);
            for(int i=0;i < isimler3.Length;i++)
            {
                System.Console.WriteLine(isimler3[i]);
            }
        }
    }
}