using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaraPayamakRestClient.DataContracts
{
    public abstract class BaseService
    {
        public readonly HttpClientManager HttpClientManager;

        protected BaseService(IFaraPayamakConfiguration configuration)
        {
            HttpClientManager = new HttpClientManager(configuration.BaseUrl);
        }
    }
}
