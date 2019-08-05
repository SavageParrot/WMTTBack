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
    public class CategoryController : ApiController
    {

        private readonly ICategoryBiz category = new CategoryBiz();

        // GET: api/Category
        public Response<Category> Get()
        {
            return category.GetAll();
        }

        // GET: api/CategoryController/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CategoryController
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CategoryController/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CategoryController/5
        public void Delete(int id)
        {
        }
    }
}
