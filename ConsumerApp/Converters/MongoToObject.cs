using System;
using ConsumerApp.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace ConsumerApp.Converters
{

	public class MongoToObject
	{
		public Event convertToObject(BsonDocument bson)
		{
			Event evento = new Event();
			evento = BsonSerializer.Deserialize<Event>(bson);
			return evento;
		}
	}
}

