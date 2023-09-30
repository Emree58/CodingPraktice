using System;

namespace CodingPraktice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dersler = new string[] { "Ingilizce", "Programlama", "Beden", "Tarih"};


            for (int i = 0; i < dersler.Length; i++)
            {
                Console.WriteLine(dersler[i]);
            }

            Console.WriteLine("----------------------------");

            foreach (string item in dersler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------");
            Muzik muzik1 = new Muzik();
            Muzik muzik2 = new Muzik();
            Muzik[] muzikler = new Muzik[] { muzik1, muzik2 };
            

            muzik1.MuzikId = 1;
            muzik1.MuzikCategory = "Pop";
            muzik1.MuzikAdi = "Seni Sevdimde uçtum";
            muzik1.MuzikArtist = "Uzayli Saziment";

            muzik2.MuzikId = 2;
            muzik2.MuzikCategory = "Tango";
            muzik2.MuzikAdi = "Dans ile uç";
            muzik2.MuzikArtist = "Marsli Husamettin";

            foreach (Muzik muzik in muzikler)
            {
                Console.WriteLine(muzik.MuzikCategory);
                Console.WriteLine(muzik.MuzikAdi);
                Console.WriteLine(muzik.MuzikArtist);
            }
        }

            
    }

    class Muzik
    {
        public int MuzikId { get; set; }
        public string MuzikAdi { get; set; }
        public string MuzikArtist { get; set; }
        public string MuzikCategory { get; set; }
    }
}

//      string[] muzikler = new string[] {"pop","rap","fantazi"};
// ders 2 , 02:38:54. Ders bitti ama class ile string bir daha gözden geçir ve tek basina yazmayi dene.




// Araba araba = new Araba();
// Araba araba2 = new Araba();
// string[] araba = new string[] {"bmw","mercedes"};

