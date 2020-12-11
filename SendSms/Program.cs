using System;
using System.Threading.Tasks;
using SmsService;

namespace SendSmsMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            //SendSMSSingleRequestBody sendSMSSingleRequestBody = new SendSMSSingleRequestBody();
            //SendSMSSingleRequest sendSMSSingleRequest = new SendSMSSingleRequest();
            //sendSMSSingleRequest.Body = sendSMSSingleRequestBody;
            //sendSMSSingleRequestBody.user = "tenmak";
            //sendSMSSingleRequestBody.password = "5369-kzR";
            //sendSMSSingleRequestBody.messages = "Test";
            SMSServiceSoap sMSServiceSoap = new SmsService.SMSServiceSoapClient(SmsService.SMSServiceSoapClient.EndpointConfiguration.SMSServiceSoap);
            Task<SendSMSSingleResponse> sendSMSSingleResponse = sMSServiceSoap.SendSMSSingleAsync(new SmsService.SendSMSSingleRequest
            {
                Body = new SmsService.SendSMSSingleRequestBody
                {
                    user = "tenmak",
                    password = "5369-kzR",
                    messages = "Test",
                    receipents = "905525022120",
                    channel= "VODAFONE NET",
                    originator="DEMO"
                }
            });
        }
    }
}
