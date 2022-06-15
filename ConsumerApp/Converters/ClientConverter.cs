using ConsumerApp.Models;
using Newtonsoft.Json;
namespace ConsumerApp.Converters
{
    public class ClientConverter
    {
        public static Client jsonToClient(string jsonString){
            Client cliente = new Client();
            cliente = JsonConvert.DeserializeObject<Client>(jsonString);
            return cliente;
        }
    }
}