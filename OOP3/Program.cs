using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
//SOLID O = OPEN/CLOSE prensipi

//Ders 5 izlendi , ödevlere basla