using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin",
            //"Murat","Ali","Mehmet"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //İsimler = new string[5];
            //İsimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);



            List<string> İsimler2 = new List<string> {"Engin",
            "Murat","Ali","Mehmet"};
            Console.WriteLine(İsimler2[0]);
            Console.WriteLine(İsimler2[1]);
            Console.WriteLine(İsimler2[2]);
            Console.WriteLine(İsimler2[3]);
            İsimler2.Add("İlker");
            Console.WriteLine(İsimler2[4]);
            Console.WriteLine(İsimler2[0]);

        }
    }
}
