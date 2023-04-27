using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediBaseManager krediBaseManager, ILoggerService loggerService)
        {
            krediBaseManager.Hesapla();
            loggerService.Log();

        }


        public void KrediOnBilgilendirmesiYap(List<IhtıyacKrediManager>krediler)
        {
            foreach (var kredi in krediler) 
            {
                kredi.Hesapla();
            
            }

        }

        internal void KrediOnBilgilendirmesiYap(List<IKrediBaseManager> krediler)
        {
            throw new NotImplementedException();
        }
    }
}
