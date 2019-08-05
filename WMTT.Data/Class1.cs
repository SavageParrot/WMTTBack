using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMTT.Data
{
    public class Class1
    {
        public int GetAll()
        {
            using (TTDBEntities db = new TTDBEntities())
            {
                DbSet<Artist> list = db.Artists;
                return list.Count();
            }
        }
    }
}
