using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMTT.Common;
using WMTT.Data.Interfaces;

namespace WMTT.Data.Implementations.Classes
{
    public class PersonData : IPersonData
    {
        public Response<Person> Delete(int idElement1, int idElement2 = 0)
        {
            try
            {
                Person delPerson;
                using (TTDBEntities db = new TTDBEntities())
                {
                    delPerson = db.Persons.Find(idElement1);
                    db.Persons.Remove(delPerson);
                    db.SaveChanges();
                }
                return new Response<Person>(null, delPerson.IdPerson, true, null);
            }
            catch (Exception err)
            {
                return new Response<Person>(err, null, false, null);
            }
        }

        public Response<Person> Get(int idElement1, int idElement2 = 0)
        {
            try
            {
                Person getPerson;
                using (TTDBEntities db = new TTDBEntities())
                {
                    getPerson = db.Persons.Find(idElement1);
                }
                return new Response<Person>(null, getPerson.IdPerson, true, getPerson);
            }
            catch (Exception err)
            {
                return new Response<Person>(err, null, false, null);
            }
        }

        public Response<Person> Post(Person element)
        {
            try
            {
                using (TTDBEntities db = new TTDBEntities())
                {
                    db.Persons.Add(element);
                    db.SaveChanges();
                }
                return new Response<Person>(null, element.IdPerson, true, null);
            }
            catch (Exception err)
            {
                return new Response<Person>(err, null, false, null);
            }
        }

        public Response<Person> Update(Person element)
        {
            try
            {
                Person updatePerson;
                using (TTDBEntities db = new TTDBEntities())
                {
                    updatePerson = db.Persons.Find(element.IdPerson);
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
                return new Response<Person>(null, updatePerson.IdPerson, true, null);
            }
            catch (Exception err)
            {
                return new Response<Person>(err, null, false, null);
            }
        }

        public Response<Person> GetAll()
        {
            try
            {
                IEnumerable<Person> allPeople;
                using (TTDBEntities db = new TTDBEntities())
                {
                    allPeople = db.Persons.ToList();
                }
                return new Response<Person>(null, null, true, null, allPeople);
            }
            catch (Exception err)
            {
                return new Response<Person>(err, null, false, null);
            }
        }
    }
}
