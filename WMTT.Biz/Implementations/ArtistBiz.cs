using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMTT.Biz.Interfaces;
using WMTT.Common;
using WMTT.Data;
using WMTT.Data.Implementations.Classes;
using WMTT.Data.Interfaces;

namespace WMTT.Biz.Implementations
{
    public class ArtistBiz : IArtistBiz
    {
        private readonly IArtistData actionPerson = new ArtistData();

        public Response<Artist> GetAll()
        {
            return actionPerson.GetAll();
        }

        public Response<Artist> Get(int idElement)
        {
            return actionPerson.Get(idElement);
        }
    }
}
