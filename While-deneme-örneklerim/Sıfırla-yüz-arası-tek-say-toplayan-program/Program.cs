using System;
namespace örnek
{
    class program
    {
        static void Main(string []args)
        {
            int artırıcıD=0,toplam=0;
        
            while(artırıcıD<100)
            {   
                if(artırıcıD%2==1)
                {
                    toplam +=artırıcıD;
                }
                artırıcıD++; 
            }
            System.Console.WriteLine(toplam);
            Console.ReadKey();
            
        }
    }
}