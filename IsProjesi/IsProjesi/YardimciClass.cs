using System.Collections.Generic;
using System.Linq;
using IsProjesi.Models;

namespace IsProjesi
{
    public class YardimciClass
    {

        public static List<ilce> ilceleriListele(int ilceId)
        {
            using (var db = new inotr_sistemEntities())
            {
                return db.ilce.Where(x => x.ilID == ilceId).ToList();
            }
        }

        




    }

   
}