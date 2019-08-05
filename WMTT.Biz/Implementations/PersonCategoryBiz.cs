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
    public class PersonCategoryBiz : IPersonCategoryBiz
    {
        private readonly IPersonCategoryData actionPerCat = new PersonCategoryData();
        public Response<Persons_Categories> GetCatPerPerson(int idPerson)
        {
            return actionPerCat.GetCatPerPerson(idPerson);
        }

        public Response<Persons_Categories> GetPersonPerCat(int idCategory)
        {
            return actionPerCat.GetPersonPerCat(idCategory);
        }
    }
}
