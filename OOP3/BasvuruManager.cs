using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void Basvuruyap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            // başvuran bilgilerini değerlendirme
            // kredi başvurusunu bağımsız hale getirdin bütün kredileri hesaplar bağımlı olma
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
