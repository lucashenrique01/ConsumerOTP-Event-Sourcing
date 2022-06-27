using BrokerContextNamespace;
using ConsumerControllerNamespace;
using ConsumerApp.Services;
using ConsumerApp.Contexts;

namespace ConsumerApp
{
    class Program
    { 
        static void Main(string[] args)
        {   
            EventTransactionService eventService = new EventTransactionService();
            eventService.createTable();
            ConsumerController consumerController = new ConsumerController();
            MongoContext mongo = new MongoContext();             
            consumerController.ListeningMongo(mongo);
        }
    }
}