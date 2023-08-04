using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // başlangıç değeri ve bitiş değer kullanıcıdan alınarak bu değer aralığındaki sayılar için 5 ve 11 katlarının toplamını 
            // ve adetini hesaplayan tek for işlemi kodlayınız?

            Console.WriteLine("Lütfen baslangıc degeri girin : ");
            int baslangıc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen bitis degeri girin : ");
            int bitis = Convert.ToInt32(Console.ReadLine());

            //bitis degerinin baslangıc degerinden buyuk olması icin;
            if (baslangıc > bitis)
            {
                while (true)
                {
                    Console.WriteLine("bitis, baslangıctan buyuk olmalidir");
                    Console.WriteLine("Lutfen bitis degeri girin : ");
                    bitis = Convert.ToInt32(Console.ReadLine());

                    if (bitis > baslangıc)
                    {
                        break;
                    }
                }
            }

            int sum = 0;
            int sayac = 0;


            for (int i = baslangıc; i <= bitis; i++)
            {
                if (i % 5 == 0 && i % 11 == 0)
                {
                    sum = sum + i;
                    sayac++;
                }
                
            }
            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("sayac : " + sayac );

            Console.Read();
        }
    }
}
