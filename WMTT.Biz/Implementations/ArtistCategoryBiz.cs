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
    public class ArtistCategoryBiz : IArtistCategoryBiz
    {
        private readonly IArtistCategoryData _actionPerCat;

        public ArtistCategoryBiz(IArtistCategoryData actionPerCat)
        {
            _actionPerCat = actionPerCat;
        }

        public Response<Category> GetCatPerPerson(int idPerson)
        {
            return _actionPerCat.GetCatPerPerson(idPerson);
        }

        public Response<Artist> GetPersonPerCat(int idCategory)
        {
            return _actionPerCat.GetPersonPerCat(idCategory);
        }
    }
}
