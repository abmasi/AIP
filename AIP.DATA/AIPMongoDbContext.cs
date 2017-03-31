using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MongoDB.Driver;
using System.Configuration;
using AIP.Model;

namespace AIP.DATA
{
    public class AIPMongoDbContext : DbContext
    {
        public const string CONNECTION_STRING_NAME = "AIP";
        public const string DATABASE_NAME = "aip";
        public const string PPERSON_COLLECTION_NAME = "person";
        public const string NEWS_COLLECTION_NAME = "news";

        public static readonly MongoClient _client;
        public static readonly MongoDatabase _database;

        static AIPMongoDbContext()
        {
            var connectionString = ConfigurationManager.ConnectionStrings[CONNECTION_STRING_NAME].ConnectionString;
            _client = new MongoClient(connectionString);
            //_database = _client.Settings.  .GetDatabase(DATABASE_NAME);
        }

        public MongoClient AIPClient
        {
            get { return _client; }
        }

        public MongoDatabase AIPDatabase
        {
            get { return _database; }
        }

        public MongoCollection<Person> PersonCollection
        {
            get { return _database.GetCollection<Person>(PPERSON_COLLECTION_NAME); }
        }

        public MongoCollection<News> NewsCollection
        {
            get { return _database.GetCollection<News>(NEWS_COLLECTION_NAME); }
        }
    }
}
