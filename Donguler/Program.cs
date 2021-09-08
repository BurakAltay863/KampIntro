using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // array - dizi

            string[] kurslar = new string[] { 
                "Yazılım Gelistirici  Kampı","Programlamaya Baslangıc kampı","Java","pyhton","c#"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            // foreach/dizi temellı yapıları tek tek dönmeye yarar
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu-footer");

           

        }
        
    }
}
