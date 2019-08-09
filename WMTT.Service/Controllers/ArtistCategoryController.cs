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
    public class ArtistCategoryController : ApiController
    {
        private readonly IArtistCategoryBiz _artistCategory;

        public ArtistCategoryController(IArtistCategoryBiz artistCategory)
        {
            _artistCategory = artistCategory;
        }

        // GET: 
        [Route("api/ArtistCategory/getArtists/{id}")]
        [HttpGet]
        public Response<Artist> GetArtists(int id)
        {
            return _artistCategory.GetPersonPerCat(id);
        }

        // GET: 
        [Route("api/ArtistCategory/getCategories/{id}")]
        [HttpGet]
        public Response<Category> GetCategories(int id)
        {
            return _artistCategory.GetCatPerPerson(id);
        }

        // POST: api/ArtistCategory
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ArtistCategory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ArtistCategory/5
        public void Delete(int id)
        {
        }
    }
}
