using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMTT.Common;
using WMTT.Data.Interfaces;

namespace WMTT.Data.Implementations.Classes
{
    public class CategoryData : ICategoryData
    {
        public Response<Category> Delete(int idElement1, int idElement2 = 0)
        {
            try
            {
                Category delCategory;
                using (TTDBEntities db = new TTDBEntities())
                {
                    delCategory = db.Categories.Find(idElement1);
                    db.Categories.Remove(delCategory);
                    db.SaveChanges();
                }
                return new Response<Category>(null, delCategory.IdCategory, true, null);
            }
            catch (Exception err)
            {
                return new Response<Category>(err, null, false, null);
            }
        }

        public Response<Category> Get(int idElement1, int idElement2 = 0)
        {
            try
            {
                Category getCategory;
                using (TTDBEntities db = new TTDBEntities())
                {
                    getCategory = db.Categories.Find(idElement1);
                }
                return new Response<Category>(null, getCategory.IdCategory, true, getCategory);
            }
            catch (Exception err)
            {
                return new Response<Category>(err, null, false, null);
            }
        }

        public Response<Category> Post(Category element)
        {
            try
            {
                using (TTDBEntities db = new TTDBEntities())
                {
                    db.Categories.Add(element);
                    db.SaveChanges();
                }
                return new Response<Category>(null, element.IdCategory, true, null);
            }
            catch (Exception err)
            {
                return new Response<Category>(err, null, false, null);
            }
        }

        public Response<Category> Update(Category element)
        {
            try
            {
                Category updateCategory;
                using (TTDBEntities db = new TTDBEntities())
                {
                    updateCategory = db.Categories.Find(element.IdCategory);
                    if (element.CategoryName != null)
                    {
                        updateCategory.CategoryName = element.CategoryName;
                    }
                    else if (element.Details != null)
                    {
                        updateCategory.Details = element.Details;
                    }
                    db.Entry(updateCategory);
                    db.SaveChanges();
                }
                return new Response<Category>(null, updateCategory.IdCategory, true, null);
            }
            catch (Exception err)
            {
                return new Response<Category>(err, null, false, null);
            }
        }

        public Response<Category> GetAll()
        {
            try
            {
                IEnumerable<Category> allCategory;
                using (TTDBEntities db = new TTDBEntities())
                {
                    allCategory = db.Categories.ToList();
                }
                return new Response<Category>(null, null, true, null, allCategory);
            }
            catch (Exception err)
            {
                return new Response<Category>(err, null, false, null);
            }
        }
    }
}
