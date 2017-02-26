using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaraPayamakRestClient.DataContracts.Models;
using Newtonsoft.Json;

namespace FaraPayamakRestClient.DataContracts.Requests
{
    public class GetMessagesRequest:BaseRequest
    {
        [JsonProperty("Location")]
        public MessageTypes MessageType { get; set; }
        [JsonProperty("From")]
        public string SenderPhoneNumber { get; set; }
        public int Index { get; set; }
        public int Count { get; set; }
    }
}
