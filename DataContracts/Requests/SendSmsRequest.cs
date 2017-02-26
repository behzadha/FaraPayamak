using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaraPayamakRestClient.DataContracts.Models;

namespace FaraPayamakRestClient.DataContracts.Requests
{
    public class SendSmsRequest : BaseRequest
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Text { get; set; }
        public bool IsFlash { get; set; }
    }
}
