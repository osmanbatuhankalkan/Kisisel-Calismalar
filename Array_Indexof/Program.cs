using System;
namespace Array_Indexof
{
    class Program
    {
        static void Main(string[] args)
        {
            //DİZİ İÇERİSİNDE BİR ELEMANIN VAR OLUP OLMADIĞINI SORGULAYABİLDİĞİMİZ FONKSİYONDUR
            Array isimler = new[]{"ali","veli","cengiz","ahmet","mehmet"};
            
            int index = Array.IndexOf(isimler,"veli");//Arama neticesinde ilgili değer varsa int olarak o değeri index numarasını döndürecektir
            //YOK İSE -1 olarak döndürür
            if(index != -1)
            {
                //Demek ki aranan değer ilgili dizide bulunmaktadır....
                System.Console.WriteLine("var");
            }
            int index2 = Array.IndexOf(isimler,"ahmet",0,4);//isimlerin içinde ahmet 0.index ile 4. index arasında ara demek

            if(index2 != -1)
            {
                //Demek ki aranan değer ilgili dizide bulunmaktadır....
                System.Console.WriteLine("var");
            }     
            }
    }
}