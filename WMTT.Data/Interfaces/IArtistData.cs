using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMTT.Common;

namespace WMTT.Data.Interfaces
{
    public interface IArtistData : IGenericData<Artist>
    {
        Response<Artist> GetAll();
    }
}
