using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Okunabilirlik için interfaceler "I" harfiyle başlatılır.
    //İnterfaceleri, birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
