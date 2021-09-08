using System;

namespace Methotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";
            product1.StokAdedi = 80;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Adana Karpuzu";
            product2.StokAdedi = 5000;

            Product[] products = new Product[] {product1,product2 };
            // type safe -- tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati+"tl");
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("STOK ADEDİ"+product.StokAdedi);
                Console.WriteLine( "..........." );
            }

            Console.WriteLine("--------Metotlar--------");
            // instance- örnek
            //encapsulation
            SepetMeneger sepetMeneger = new SepetMeneger();
            sepetMeneger.Ekle(product1);
            sepetMeneger.Ekle(product2);

        }
    }
}
// Dont repeat yourself-DRY-Clean Code-Best Pratice
