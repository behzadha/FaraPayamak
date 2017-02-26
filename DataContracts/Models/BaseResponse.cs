using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaraPayamakRestClient.DataContracts.Models
{
    public class BaseResponse
    {
        public int RetStatus { get; set; }
        public string StrRetStatus { get; set; }
    }
}
