using System;

namespace ClasIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Tayfun Ktılmıs";
            kurs2.İzlenmeOrani = 60;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "pyhton";
            kurs3.Egitmen = "Burak Altay";
            kurs3.İzlenmeOrani = 82;

            //Console.WriteLine(kurs1.KursAdi+ " : " +kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };



            foreach (var kurs in kurslar)

            {
                Console.WriteLine("Kurs adı:"+kurs.KursAdi);
            }
            Kayit kayit1 = new Kayit();

            kayit1.Age = 38;
            kayit1.Name = "Banu";
            kayit1.SurName = "İşten";

            Kayit kayit2 = new Kayit();

            kayit2.Age = 38;
            kayit2.Name = "Hande";
            kayit2.SurName = "İşten";

            Kayit[] kayıtlar = new Kayit[] {kayit1 , kayit2};

            foreach (var kayit in kayıtlar)
            {
                Console.WriteLine(kayit.Name +" " + kayit.SurName+ " : "+ kayit.Age);
            }
        }
       
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int İzlenmeOrani { get; set; }


    }

    class Kayit
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public int Age { get; set; }
    }
    

    
}
