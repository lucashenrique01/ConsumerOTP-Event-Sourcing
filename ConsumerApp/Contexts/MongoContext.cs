using MongoDB.Bson;  
using MongoDB.Bson.Serialization;
using MongoDB.Driver;  
using System;
using Newtonsoft.Json;
using ConsumerApp.Models;

namespace ConsumerApp.Contexts
{
    public class MongoContext
    {
        public MongoClient connectdb(string host){
            MongoClient dbClient = new MongoClient($"{host}");                       
            return dbClient;           
        }

        public string getHostMongo(){
             string host;
            if (Environment.GetEnvironmentVariable("MONGO_HOST") != null)
            {
                host = Environment.GetEnvironmentVariable("MONGO_HOST");
            } else {
                return host = "mongodb://localhost:27017";
            }
            return host;
        }

        public string getDatabase(){
            string database;
            if (Environment.GetEnvironmentVariable("MONGO_DATABASE") != null)
            {
                database = Environment.GetEnvironmentVariable("MONGO_DATABASE");
            } else {
                return database = "teste";
            }
            return database;
        }
    }
}