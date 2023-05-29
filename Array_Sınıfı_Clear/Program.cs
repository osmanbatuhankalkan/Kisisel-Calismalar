using System;
using System.Collections.Generic;
using System.IO;

namespace Person
{
class program
        {
    static void Main(String[] args) 
    {
        //CLEAR
        Array isimler = new[]{"Hilmi","Hüseyin","ALi","Veli","Tan"};
        /*Dizi içerisindeki tüm elemanlar siliniyor olarak bilinir Fakat bu yanlış bir bilgidir.
        Dizi içerisindeki tüm elemanlara, dizi türüne uygun default değerleri atayan bir Fonksiyondur.  */
        for(int i =0;i<isimler.Length;i++)
        {
            System.Console.WriteLine(isimler.GetValue(i));
        }
        Array.Clear(isimler,1,2);
        System.Console.WriteLine("*******************************");
        for(int i=0;i<isimler.Length;i++)
        {
            System.Console.WriteLine(isimler.GetValue(i));
        }
            
    }

    }
}