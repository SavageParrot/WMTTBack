using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMTT.Common;
using WMTT.Data.Interfaces;

namespace WMTT.Data.Implementations.Classes
{
    public class PersonCategoryData : IPersonCategoryData
    {
        public Response<Persons_Categories> Delete(int idElement1, int idElement2)
        {
            try
            {
                Persons_Categories delPerson_Category = new Persons_Categories();
                using (TTDBEntities db = new TTDBEntities())
                {
                    delPerson_Category = db.Persons_Categories.Find(idElement1, idElement2);
                    db.Persons_Categories.Remove(delPerson_Category);
                    db.SaveChanges();
                }
                return new Response<Persons_Categories>(null, delPerson_Category.IdCategory, true, null);
            }
            catch (Exception err)
            {
                return new Response<Persons_Categories>(err, null, false, null);
            }
        }

        public Response<Persons_Categories> Get(int idElement1, int idElement2)
        {
            try
            {
                Persons_Categories getPerson_Category = new Persons_Categories();
                using (TTDBEntities db = new TTDBEntities())
                {
                    getPerson_Category = db.Persons_Categories.Find(idElement1, idElement2);
                }
                return new Response<Persons_Categories>(null, getPerson_Category.IdCategory, true, null);
            }
            catch (Exception err)
            {
                return new Response<Persons_Categories>(err, null, false, null);
            }
        }

        public Response<Persons_Categories> Post(Persons_Categories element)
        {
            try
            {
                using (TTDBEntities db = new TTDBEntities())
                {
                    db.Persons_Categories.Add(element);
                    db.SaveChanges();
                }
                return new Response<Persons_Categories>(null, element.IdCategory, true, null);
            }
            catch (Exception err)
            {
                return new Response<Persons_Categories>(err, null, false, null);
            }
        }

        public Response<Persons_Categories> Update(Persons_Categories element)
        {
            try
            {
                Persons_Categories updatePerson_Category;
                using (TTDBEntities db = new TTDBEntities())
                {
                    updatePerson_Category = db.Persons_Categories.Find(element.Idperson, element.IdCategory);
                    if (element.Obsevation != null)
                    {
                        updatePerson_Category.Obsevation = element.Obsevation;
                    }
                    db.Entry(updatePerson_Category);
                    db.SaveChanges();
                }
                return new Response<Persons_Categories>(null, updatePerson_Category.IdCategory, true, null);
            }
            catch (Exception err)
            {
                return new Response<Persons_Categories>(err, null, false, null);
            }
        }

        public Response<Persons_Categories> GetCatPerPerson(int idPerson)
        {
            try
            {
                IEnumerable<Persons_Categories> allCategories;
                using (TTDBEntities db = new TTDBEntities())
                {
                    allCategories = db.Persons_Categories.Where(x => x.Idperson == idPerson).ToList();
                }
                return new Response<Persons_Categories>(null, null, true, null, allCategories);
            }
            catch (Exception err)
            {
                return new Response<Persons_Categories>(err, null, false, null);
            }
        }

        public Response<Persons_Categories> GetPersonPerCat(int idCategory)
        {
            try
            {
                IEnumerable<Persons_Categories> allPeople;
                using (TTDBEntities db = new TTDBEntities())
                {
                    allPeople = db.Persons_Categories.Where(x => x.IdCategory == idCategory).ToList();
                }
                return new Response<Persons_Categories>(null, null, true, null, allPeople);
            }
            catch (Exception err)
            {
                return new Response<Persons_Categories>(err, null, false, null);
            }
        }
    }
}
