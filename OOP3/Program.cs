using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface onu implemente eden clasın referansını tutabilir
            IKrediManeger ihtiyacKrediManeger = new İhtiyacKrediManeger();        
            IKrediManeger tasıtKrediManeger = new TasıtKrediManeger();
            IKrediManeger konutKrediManeger = new KonutKrediManeger();

           
            ILoggerService databaseLoggerService = new DatabaseLogerService();
            ILoggerService fileLoggerService = new FileLogeerService();
            BasvuruManeger basvuruManeger = new BasvuruManeger();
            basvuruManeger.BasvuruYap(konutKrediManeger,databaseLoggerService);

            List<IKrediManeger> krediler = new List<IKrediManeger>() {ihtiyacKrediManeger,tasıtKrediManeger };
            //basvuruManeger.KrediOnBilgilendirmesiYap(krediler);
           


        }
    }
}
