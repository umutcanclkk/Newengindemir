using System;

namespace Newengindemir
{
   public class Program
    {
        static void Main(string[] args)
        {
          

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2= new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyat = 82;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            

            Urun urun3= new Urun();
            urun3.Adi = "Uzum";
            urun3.Fiyat= 10;
            urun3.Aciklama="Erzincan Uzumu";





            Urun[] urunler = new Urun[] { urun1, urun2, urun3, };

            foreach(Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------");

            }

            Console.WriteLine("-------METOTLAR----");

            SepetManager Sm = new SepetManager();
            Sm.Ekle(urun1); 
            Sm.Ekle(urun2);
            Sm.Ekle(urun3);

            Sm.Ekle2("Armu", "Yeşil Armut", 12,10);
            Sm.Ekle2("Elma", "Yeşil Elma", 12,25);
            Sm.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,10);




        }
    }
}
