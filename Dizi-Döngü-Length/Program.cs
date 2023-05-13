using System;
namespace Dizi_Döngü_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]personeller=new string[18];
            personeller[0]="ali";
            personeller[1]="ayse";
            personeller[2]="fatma";
            personeller[3]="veli";
            personeller[4]="mehmet";
            personeller[5]="ahmet";
            personeller[6]="can";
            personeller[7]="ece";
            personeller[8]="ezgi";
            personeller[9]="şenol";

            for(int i=0;i<personeller.Length;i++)
            {
                System.Console.WriteLine(personeller[i]);
            }
            System.Console.WriteLine("Bellekte Rezerv Şekilde Bekleyen Default Değerler");
        }
    }
}