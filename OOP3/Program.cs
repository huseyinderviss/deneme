using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {// ı kredi manager ile ihtiyaç kredisi manager birbirinin referansını tutar interface denir
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            
            IKrediManager tasitKrediManager = new TasitKrediManager();
            
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService= new SmsLoggerService();
            BasvuruManager basvuruManager = new BasvuruManager();
           
            List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService, smsLoggerService, fileLoggerService };
            // alttaki altarnatif kodu listenin
            basvuruManager.Basvuruyap(ihtiyacKrediManager, loggers/*new List<ILoggerService> { new DatabaseLoggerService(),new SmsLoggerService ()}*/);

            List<IKrediManager> krediler = new List<IKrediManager>() { /* gönderilen krediyi başvuru bilgisi için listeye alır
                                                                        ve listede karşılaştırır*/ihtiyacKrediManager, tasitKrediManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
