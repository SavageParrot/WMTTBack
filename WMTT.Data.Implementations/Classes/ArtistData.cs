using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMTT.Common;
using WMTT.Data.Interfaces;

namespace WMTT.Data.Implementations.Classes
{
    public class ArtistData : IArtistData
    {
        public Response<Artist> Delete(int idElement1, int idElement2 = 0)
        {
            try
            {
                Artist delPerson;
                using (TTDBEntities db = new TTDBEntities())
                {
                    delPerson = db.Artists.Find(idElement1);
                    db.Artists.Remove(delPerson);
                    db.SaveChanges();
                }
                return new Response<Artist>(null, delPerson.IdArtist, true, null);
            }
            catch (Exception err)
            {
                return new Response<Artist>(err, null, false, null);
            }
        }

        public Response<Artist> Get(int idElement1, int idElement2 = 0)
        {
            try
            {
                Artist getPerson;
                using (TTDBEntities db = new TTDBEntities())
                {
                    getPerson = db.Artists.Find(idElement1);
                }
                return new Response<Artist>(null, getPerson.IdArtist, true, getPerson);
            }
            catch (Exception err)
            {
                return new Response<Artist>(err, null, false, null);
            }
        }

        public Response<Artist> Post(Artist element)
        {
            try
            {
                using (TTDBEntities db = new TTDBEntities())
                {
                    db.Artists.Add(element);
                    db.SaveChanges();
                }
                return new Response<Artist>(null, element.IdArtist, true, null);
            }
            catch (Exception err)
            {
                return new Response<Artist>(err, null, false, null);
            }
        }

        public Response<Artist> Update(Artist element)
        {
            try
            {
                Artist updatePerson;
                using (TTDBEntities db = new TTDBEntities())
                {
                    updatePerson = db.Artists.Find(element.IdArtist);
                    if (element.FullName != null)
                    {
                        updatePerson.FullName = element.FullName;
                    }
                    else if (element.BirthDate != null)
                    {
                        updatePerson.BirthDate = element.BirthDate;
                    }
                    else if (element.StartDate != null)
                    {
                        updatePerson.StartDate = element.StartDate;
                    }
                    else if (element.Email != null)
                    {
                        updatePerson.Email = element.Email;
                    }
                    else if (element.PhoneNumber != null)
                    {
                        updatePerson.PhoneNumber = element.PhoneNumber;
                    }
                    else if (element.Address != null)
                    {
                        updatePerson.Address = element.Address;
                    }
                    db.Entry(updatePerson);
                    db.SaveChanges();
                }
                return new Response<Artist>(null, updatePerson.IdArtist, true, null);
            }
            catch (Exception err)
            {
                return new Response<Artist>(err, null, false, null);
            }
        }

        public Response<Artist> GetAll()
        {
            try
            {
                IEnumerable<Artist> allPeople;
                using (TTDBEntities db = new TTDBEntities())
                {
                    allPeople = db.Artists.ToList();
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
