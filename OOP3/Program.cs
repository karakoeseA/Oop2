using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediBaseManager ıhtıyacKrediManager = new  IhtıyacKrediManager();           
            IKrediBaseManager tasitKrediManager = new TasitKrediManager();           
            IKrediBaseManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
           
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ıhtıyacKrediManager,databaseLoggerService);

            List<IKrediBaseManager>krediler = new List<IKrediBaseManager>() {ıhtıyacKrediManager,tasitKrediManager,konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }

    }
}
