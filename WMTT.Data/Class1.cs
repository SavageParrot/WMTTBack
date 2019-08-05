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
                DbSet<Person> list = db.Persons;
                return list.Count();
            }
        }
    }
}
