using FaraPayamakRestClient.DataContracts;

namespace FaraPayamakRestClient
{
   public class FaraPayamakClient
   {
        public FaraPayamakClient(IFaraPayamakConfiguration configuration)
        {
            Sms = new SmsService(configuration);
        }
        public SmsService Sms { get; }
    }
}
