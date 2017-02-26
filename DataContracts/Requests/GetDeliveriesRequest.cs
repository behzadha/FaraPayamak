using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaraPayamakRestClient.DataContracts.Models;
using Newtonsoft.Json;

namespace FaraPayamakRestClient.DataContracts.Requests
{
    public class GetDeliveriesRequest: BaseRequest
    {
        [JsonProperty("recId")]
        public long RecId { get; set; }
    }
}
