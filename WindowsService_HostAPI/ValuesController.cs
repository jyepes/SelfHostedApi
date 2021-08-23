using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WindowsService_HostAPI
{
    public class ValuesController: ApiController
    {

        public string GetString(Int32 id)
        {
            return "Este es un string retornado a través de un Windows Service";
        }
    }
}
