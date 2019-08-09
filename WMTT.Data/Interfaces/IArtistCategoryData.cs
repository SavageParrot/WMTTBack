using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMTT.Common;

namespace WMTT.Data.Interfaces
{
    public interface IArtistCategoryData : IGenericData<Artists_Categories>
    {
        Response<Category> GetCatPerPerson(int idArtist);
        Response<Artist> GetPersonPerCat(int idCategory);
    }
}
