using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaraPayamakRestClient.DataContracts.Requests;
using FaraPayamakRestClient.DataContracts.Responses;

namespace FaraPayamakRestClient.DataContracts
{
   public class SmsService : BaseService
   {
       private readonly IFaraPayamakConfiguration _configuration;
        public SmsService(IFaraPayamakConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public async Task< Responses.SendSmsResponse> SendSms(SendSmsRequest request)
        {
            request.Username = _configuration.Username;
            request.Password = _configuration.Password;
            return await HttpClientManager.Post<SendSmsRequest, SendSmsResponse>("SendSms",request);
        }

        public async Task<GetDeliveriesResponse> GetDeliveries(GetDeliveriesRequest request)
        {
            request.Username = _configuration.Username;
            request.Password = _configuration.Password;
            return await HttpClientManager.Post<GetDeliveriesRequest, GetDeliveriesResponse>("GetDeliveries2", request);
        }

        public async Task<GetMessagesResponse> GetMessages(GetMessagesRequest request)
        {
            request.Username = _configuration.Username;
            request.Password = _configuration.Password;
            return await HttpClientManager.Post<GetMessagesRequest, GetMessagesResponse>("GetMessages", request);
        }
        public async Task<GetCreditResponse> GetCredit(GetCreditRequest request)
        {
            request.Username = _configuration.Username;
            request.Password = _configuration.Password;
            return await HttpClientManager.Post<GetCreditRequest, GetCreditResponse>("GetCredit", request);
        }
    }
}
