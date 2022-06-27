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


        EventTransactionService eventTransactionService = new EventTransactionService();
        MongoToObject mongoToObject = new MongoToObject();

        public void ListeningMongo(MongoContext mongo){
            MongoClient dbClient = new MongoClient($"{mongo.getHostMongo()}");
            var database = dbClient.GetDatabase($"{mongo.getDatabase()}"); 
            var collections = database.GetCollection<BsonDocument>($"{mongo.getCollection()}");  
            int contador = 0;
            while (true)
             {                                        
                    var documents = collections.Find(new BsonDocument()).ToList();
                    try
                    {
                        for(int i = contador; contador < documents.Count; contador++)
                        { 
                            eventTransactionService.save(mongoToObject.convertToObject(documents[contador]));                        
                        }                    
                    }catch (Exception ex) { 
                        Console.WriteLine("Erro ao tententar inserir um evento: " + ex.Message);    
                    }finally { Thread.Sleep(20000);}                    
             }
        }
    }
}
