using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMTT.Common;

namespace WMTT.Data.Interfaces
{
    public interface IPersonCategoryData : IGenericData<Persons_Categories>
    {
        Response<Persons_Categories> GetCatPerPerson(int idPerson);
        Response<Persons_Categories> GetPersonPerCat(int idCategory);
    }
}
