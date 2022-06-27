using Newtonsoft.Json.Linq;
using MongoDB.Bson; 
using MongoDB.Bson.Serialization.Attributes;
namespace ConsumerApp.Models
{
    public class Event {
        [BsonIgnoreIfNull]
        [BsonId]        
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get;set; }
        public string id {get; set;}
        public string specVersion {get; set;}
        public string source {get; set;}
        public string type {get;set;}
        public string subject {get;set;}
        public string time {get;set;}
        [BsonIgnoreIfNull]
        public string correlationId {get;set;}
        public string dataContentType {get;set;}
        public ClientOTP data {get;set;}

        public Event(string id, string specVersion, string source, string type, string subject, string time, string correlationid,
        string datacontentype, ClientOTP data)
        {
            this.id=id;
            this.specVersion=specVersion;
            this.source=source;
            this.type=type;
            this.subject=subject;
            this.time=time;
            this.correlationId=correlationid;
            this.dataContentType=datacontentype;
            this.data=data;
        }     
        public Event(){
            
        }
        
       
    }
}