using ConsumerApp.Models;
using Newtonsoft.Json;
namespace ConsumerApp.Converters
{
    public class ClientOTPConverter
    {
        public static ClientOTP jsonToClientOTP(string jsonString){
            ClientOTP clienteOTP = new ClientOTP();
            clienteOTP = JsonConvert.DeserializeObject<ClientOTP>(jsonString);
            return clienteOTP;
        }
    }
}