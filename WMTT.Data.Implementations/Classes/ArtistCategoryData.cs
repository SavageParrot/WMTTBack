using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMTT.Common;
using WMTT.Data.Interfaces;

namespace WMTT.Data.Implementations.Classes
{
    public class ArtistCategoryData : IArtistCategoryData
    {
        public Response<Artists_Categories> Delete(int idElement1, int idElement2 = 0)
        {
            try
            {
                Artists_Categories delPerson_Category;
                using (TTDBEntities db = new TTDBEntities())
                {
                    delPerson_Category = db.Artists_Categories.Find(idElement1, idElement2);
                    db.Artists_Categories.Remove(delPerson_Category);
                    db.SaveChanges();
                }
                return new Response<Artists_Categories>(null, delPerson_Category.IdCategory, true, null);
            }
            catch (Exception err)
            {
                return new Response<Artists_Categories>(err, null, false, null);
            }
        }

        public Response<Artists_Categories> Get(int idElement1, int idElement2 = 0)
        {
            try
            {
                Artists_Categories getPerson_Category;
                using (TTDBEntities db = new TTDBEntities())
                {
                    getPerson_Category = db.Artists_Categories.Find(idElement1, idElement2);
                }
                return new Response<Artists_Categories>(null, getPerson_Category.IdCategory, true, null);
            }
            catch (Exception err)
            {
                return new Response<Artists_Categories>(err, null, false, null);
            }
        }

        public Response<Artists_Categories> Post(Artists_Categories element)
        {
            try
            {
                using (TTDBEntities db = new TTDBEntities())
                {
                    db.Artists_Categories.Add(element);
                    db.SaveChanges();
                }
                return new Response<Artists_Categories>(null, element.IdCategory, true, null);
            }
            catch (Exception err)
            {
                return new Response<Artists_Categories>(err, null, false, null);
            }
        }

        public Response<Artists_Categories> Update(Artists_Categories element)
        {
            try
            {
                Artists_Categories updatePerson_Category;
                using (TTDBEntities db = new TTDBEntities())
                {
                    updatePerson_Category = db.Artists_Categories.Find(element.IdArtist, element.IdCategory);
                    if (element.Observation != null)
                    {
                        updatePerson_Category.Observation = element.Observation;
                    }
                    db.Entry(updatePerson_Category);
                    db.SaveChanges();
                }
                return new Response<Artists_Categories>(null, updatePerson_Category.IdCategory, true, null);
            }
            catch (Exception err)
            {
                return new Response<Artists_Categories>(err, null, false, null);
            }
        }

        public Response<Artists_Categories> GetCatPerPerson(int idPerson)
        {
            try
            {
                IEnumerable<Artists_Categories> allCategories;
                using (TTDBEntities db = new TTDBEntities())
                {
                    allCategories = db.Artists_Categories.Where(x => x.IdArtist == idPerson).ToList();
                }
                return new Response<Artists_Categories>(null, null, true, null, allCategories);
            }
            catch (Exception err)
            {
                return new Response<Artists_Categories>(err, null, false, null);
            }
        }

        public Response<Artists_Categories> GetPersonPerCat(int idCategory)
        {
            try
            {
                IEnumerable<Artists_Categories> allPeople;
                using (TTDBEntities db = new TTDBEntities())
                {
                    allPeople = db.Artists_Categories.Where(x => x.IdCategory == idCategory).ToList();
                }
                return new Response<Artists_Categories>(null, null, true, null, allPeople);
            }
            catch (Exception err)
            {
                return new Response<Artists_Categories>(err, null, false, null);
            }
        }
    }
}
