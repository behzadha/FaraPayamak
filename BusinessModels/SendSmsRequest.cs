using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaraPayamakRestClient.BusinessModels
{
    public class SendSmsRequest
    {
        public List<string> RecipientPhoneNumbers { get; set; }
        public bool IsFlash { get; set; }
        public string Content { get; set; }
    }
}
