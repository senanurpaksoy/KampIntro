using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager  ihtiyacKrediManager = new IhtiyacKrediManager(); 
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseloggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
