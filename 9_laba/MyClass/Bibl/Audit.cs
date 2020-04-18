using System;
using System.IO;

namespace MyClass
{
    public class Audit
    {
        #region run/stop
        public static void RunAudit()
        {
            Magazine.Subscribe += new ProcessMagazineDelegate(Audit.MetodSubs); 
        }

        public static void StopAudit()
        {
            Magazine.Subscribe -= new ProcessMagazineDelegate(Audit.MetodSubs);
        }
        #endregion

        public static void MetodSubs(Magazine mg, DateTime dt)
        {
            try
            {
                StreamWriter sw = new StreamWriter("infoSubscribe.txt", true);
                sw.WriteLine("Подписка на журнал {0} оформлена {1}\n", mg.Number, dt);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
