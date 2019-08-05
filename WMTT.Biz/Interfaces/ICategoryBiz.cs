using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMTT.Common;
using WMTT.Data;

namespace WMTT.Biz.Interfaces
{
    public interface ICategoryBiz 
    {
        Response<Category> GetAll();
    }
}
