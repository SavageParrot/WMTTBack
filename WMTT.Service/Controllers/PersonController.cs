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
    public class PersonController : ApiController
    {

        private readonly IArtistBiz person = new ArtistBiz();

        // GET: api/Person
        public Response<Artist> Get()
        {
            return person.GetAll();
        }

        // GET: api/Person/5
        public Response<Artist> Get(int id)
        {
            return person.Get(id);
        }

        // POST: api/Person
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
