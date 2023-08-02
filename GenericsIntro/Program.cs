using System;

namespace GenericsIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
          MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            Console.WriteLine(isimler.Length);


            isimler.Add("Ali");
            Console.WriteLine(isimler.Length);


            foreach (var isim in isimler.Items) 
            {
                Console.WriteLine(isim);
            }


        }
    }
}
