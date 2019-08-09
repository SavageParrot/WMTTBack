using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public Response<Category> GetCatPerPerson(int idArtist)
        {
            try
            {
                IEnumerable<Category> allCategories;
                using (TTDBEntities db = new TTDBEntities())
                {

                    //allCategories = (from category in db.Categories
                    //                 join artist_category in db.Artists_Categories on category.IdCategory equals artist_category.IdCategory
                    //                 where artist_category.IdArtist == idPerson
                    //                 select new Category
                    //                 {
                    //                     IdCategory = category.IdCategory,
                    //                     CategoryName = category.CategoryName,
                    //                     Details = category.Details
                    //                 }).ToList()
                    //                .Select(x => new Category
                    //                {
                    //                    IdCategory = x.IdCategory,
                    //                    CategoryName = x.CategoryName,
                    //                    Details = x.Details,
                    //                });

                    allCategories = db.Artists_Categories.Where(ip => ip.IdArtist == idArtist).Include(a => a.Category).Select(x => x.Category)/*.Distinct()*/.ToList();

                }
                return new Response<Category>(null, null, true, null, allCategories);
                }
            catch (Exception err)
            {
                return new Response<Category>(err, null, false, null);
            }
        }

        public Response<Artist> GetPersonPerCat(int idCategory)
        {
            try
            {
                IEnumerable<Artist> allPeople;
                using (TTDBEntities db = new TTDBEntities())
                {
                    //allPeople = (from artist in db.Artists
                    //             join artist_category in db.Artists_Categories on artist.IdArtist equals artist_category.IdArtist
                    //             where artist_category.IdCategory == idCategory
                    //             select new
                    //             {
                    //                 IdArtist = artist.IdArtist,
                    //                 BirthDate = artist.BirthDate,
                    //                 FullName = artist.FullName,
                    //                 Address = artist.Address,
                    //                 Email = artist.Email,
                    //                 PhoneNumber = artist.PhoneNumber,
                    //                 StartDate = artist.StartDate
                    //             }).ToList()
                    //            .Select(x => new Artist
                    //            {
                    //                IdArtist = x.IdArtist,
                    //                BirthDate = x.BirthDate,
                    //                FullName = x.FullName,
                    //                Address = x.Address,
                    //                Email = x.Email,
                    //                PhoneNumber = x.PhoneNumber,
                    //                StartDate = x.StartDate
                    //            });

                    allPeople = db.Artists_Categories.Where(ac => ac.IdCategory == idCategory).Include(a => a.Artist).Select(x => x.Artist)/*.Distinct()*/.ToList();
                    
                }
                return new Response<Artist>(null, null, true, null, allPeople);
            }
            catch (Exception err)
            {
                return new Response<Artist>(err, null, false, null);
            }
        }
    }
}
