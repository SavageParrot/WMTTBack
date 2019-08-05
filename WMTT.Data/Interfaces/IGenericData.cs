using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMTT.Common;

namespace WMTT.Data.Interfaces
{
    public interface IGenericData <T>
    {
        Response<T> Post(T element);
        Response<T> Get(int idElement1, int idElement2 = 0);
        Response<T> Update(T element);
        Response<T> Delete(int idElement1, int idElement2 = 0);
    }
}
