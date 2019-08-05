using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMTT.Common
{
    public class Response<T>
    {
        public int? idElement { get; set; }
        public string errorMessage { get; set; }
        public bool? succeed { get; set; }
        public T response { get; set; }
        public IEnumerable<T> list { get; set; }


        public Response(Exception err, int? idElement, bool succeed, T response, IEnumerable<T> list = null)
        {

            string error = err?.InnerException?.InnerException?.Message;
            if (error == null)
            {
                this.errorMessage = err?.Message;
            }
            else
            {
                this.errorMessage = error;
            }

            this.idElement = idElement;
            this.succeed = succeed;
            this.response = response;
            this.list = list;
        }
    }
}
