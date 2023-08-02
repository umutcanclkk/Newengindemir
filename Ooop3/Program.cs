using OOP3;
using System;
using System.Collections.Generic;

namespace Ooop3
{
    public class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManger = new TasıtKrediManger();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager=new EsnafKredisiManager();

            ILoggerService databasseLoggerService = new DatabasseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService=new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(),new FileLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers);
            



            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager,tasıtKrediManger };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler); 
        }
    }
}
