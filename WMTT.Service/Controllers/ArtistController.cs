using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WMTT.Biz.Implementations;
using WMTT.Biz.Interfaces;
using WMTT.Common;
using WMTT.Data;

namespace WMTT.Service.Controllers
{
    public class ArtistController : ApiController
    {

        private readonly IArtistBiz _artist ;

        public ArtistController(IArtistBiz artist)
        {
            _artist = artist;
        }

        // GET: api/Artist
        public Response<Artist> Get()
        {
            return _artist.GetAll();
        }

        // GET: api/Artist/5
        public Response<Artist> Get(int id)
        {
            return _artist.Get(id);
        }

        // POST: api/Artist
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Artist/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Artist/5
        public void Delete(int id)
        {
        }
    }
}
