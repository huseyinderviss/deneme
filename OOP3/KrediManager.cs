using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
        // interfaceler birbirinin altarnetifi olan ama kod içerikleri farklı olan durumlar için kullanılır
        // kredi türlerinin hepsinde ödeme planı ortak ama bütün krediler aynı faizde değil kodları farklıdır
    {
        void Hesapla();
        void BiseyYap();
        
    }
}
