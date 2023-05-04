using System;
namespace Deneme_Örnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sayını faktöriyelini While ile alma
            System.Console.WriteLine("Faktoriyelini almak istediğiniz değeri giriniz......");
            int alınanSayı=int.Parse(Console.ReadLine());
            int carpımToplam=1;
            int faktoriyelDeger = alınanSayı;
            
            while(alınanSayı>=1)
           {
                 carpımToplam *=alınanSayı--;
           } 
           System.Console.WriteLine("{0,0}{1,0}{2,1}{3,1}",faktoriyelDeger,"!","=",carpımToplam);
        }
    }
}