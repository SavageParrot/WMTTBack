using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WMTT.Biz.Implementations;
using WMTT.Biz.Interfaces;
using WMTT.Common;
using WMTT.Data;

namespace WMTT.Service.Controllers
{
    public class PersonCategoryController : ApiController
    {
        private readonly IArtistCategoryBiz personCategory = new ArtistCategoryBiz();

        // GET: 
        [Route("api/Person_Category/getPeople/{id}")]
        [HttpGet]
        public Response<Artists_Categories> GetPeople(int id)
        {
            return personCategory.GetPersonPerCat(id);
        }

        // GET: 
        [Route("api/Person_Category/getCategories/{id}")]
        [HttpGet]
        public Response<Artists_Categories> Get(int id)
        {
            return personCategory.GetCatPerPerson(id);
        }

        // POST: api/PersonCategory
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PersonCategory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PersonCategory/5
        public void Delete(int id)
        {
        }
    }
}
