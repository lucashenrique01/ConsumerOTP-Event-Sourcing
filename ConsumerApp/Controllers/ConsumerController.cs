using MongoDB.Bson;  
using MongoDB.Bson.Serialization;
using MongoDB.Driver;  
using System;
using System.Threading;
using BrokerContextNamespace;
using ConsumerApp.Services;
using ConsumerApp.Converters;
using EventDaoNamespace;
using ConsumerApp.Contexts;

namespace ConsumerControllerNamespace
{   
    class ConsumerController {


        EventDAO eventDao = new EventDAO(); 
        
        public void ListeningMongo(MongoContext mongo){
           
            //while (true)
                //{   
                    
                    MongoClient dbClient = new MongoClient($"{mongo.getHostMongo()}");
                    var database = dbClient.GetDatabase($"{mongo.getDatabase()}"); 
                    var collections = database.GetCollection<BsonDocument>($"teste");                    
                    var documents = collections.Find(new BsonDocument()).ToList();
                    foreach(BsonDocument doc in documents)
                    {  
                        //eventDao.insertEvent();
                        Console.WriteLine(doc.GetType());
                    }
                //}

        }
    }
}
