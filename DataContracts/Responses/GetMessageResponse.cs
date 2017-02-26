using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaraPayamakRestClient.DataContracts.Models;

namespace FaraPayamakRestClient.DataContracts.Responses
{
    public class GetMessagesResponse:BaseResponse
    {
        public string Value { get; set; }
    }
}
