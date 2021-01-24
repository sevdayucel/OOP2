﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        
            public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {

            //Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            //loggerService.Log();
            foreach (var LoggerService in loggerService)  
            {
                LoggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }

    }
}
