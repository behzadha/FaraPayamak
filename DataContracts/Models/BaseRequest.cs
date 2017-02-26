using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FaraPayamakRestClient.DataContracts.Models
{
    public class BaseRequest
    {
        [JsonProperty("UserName")]
        public string Username { get; set; }
        [JsonProperty("PassWord")]
        public string Password { get; set; }

    }
}
