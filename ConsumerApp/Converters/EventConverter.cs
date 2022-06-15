using ConsumerApp.Models;
using Newtonsoft.Json;
namespace ConsumerApp.Converters
{
    public class EventConverter
    {
        public static Event jsonToEvent(string jsonString){
            Event evento = new Event();
            evento = JsonConvert.DeserializeObject<Event>(jsonString);
            //evento = JsonSerializer.Deserialize<Event>(jsonString);
            return evento;
        }
    }
}