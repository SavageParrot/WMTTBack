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
        Response<Artists_Categories> GetCatPerPerson(int idPerson);
        Response<Artists_Categories> GetPersonPerCat(int idCategory);
    }
}
