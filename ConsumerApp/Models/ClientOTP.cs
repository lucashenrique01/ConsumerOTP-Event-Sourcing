using Newtonsoft.Json.Linq;
namespace ConsumerApp.Models
{
    public class ClientOTP
    {
        public JObject cliente {get; set;}
        public string pocType {get; set;}
        public string escolhaEnvio {get; set;}
        public string canalSolicitante {get; set;}
        public string idTransacao {get; set;}
    }
}