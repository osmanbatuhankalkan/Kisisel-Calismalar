using System;
namespace Pratikler
{
    class Program
    {
        static void Main(string[] args)
        {
            //bu for döngüsü ile de yapılabilir while ilede fakat fıtrat olarak for sayılabilen ardışık sayılara,while ise sonsuz döngülere daha uygun demiştik.
            while(true)
            {
                if(DateTime.Now.Second %5 == 0)
               {
                System.Console.WriteLine(DateTime.Now);
                
               } 
            }

        }
    }
}