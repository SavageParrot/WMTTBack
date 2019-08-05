using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMTT.Common;
using WMTT.Data;

namespace WMTT.Biz.Interfaces
{
    public interface IPersonCategoryBiz
    {
        Response<Persons_Categories> GetCatPerPerson(int idPerson);
        Response<Persons_Categories> GetPersonPerCat(int idCategory);
    }
}
