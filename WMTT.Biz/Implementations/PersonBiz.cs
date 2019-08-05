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
    public class PersonBiz : IPersonBiz
    {
        private readonly IPersonData actionPerson = new PersonData();

        public Response<Person> GetAll()
        {
            return actionPerson.GetAll();
        }

        public Response<Person> Get(int idElement)
        {
            return actionPerson.Get(idElement);
        }
    }
}
