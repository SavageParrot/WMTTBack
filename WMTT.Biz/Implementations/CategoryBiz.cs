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
    public class CategoryBiz : ICategoryBiz
    {
        private readonly ICategoryData _actionCategory;

        public CategoryBiz(ICategoryData actionCategory)
        {
            _actionCategory = actionCategory;
        }

        public Response<Category> GetAll()
        {
            return _actionCategory.GetAll();
        }
    }
}
