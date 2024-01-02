using Jcf.CursoApiRestFul.Api.Configs;
using Jcf.CursoApiRestFul.Api.Entities;
using MongoDB.Driver;

namespace Jcf.CursoApiRestFul.Api.Data.Repositories
{
    public class MongoRepository<T> : IMongoRepository<T> where T : BaseEntity
    {
        private readonly IMongoCollection<T> _collection;   

        public MongoRepository(IDatabaseSettings settings) 
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<T>(typeof(T).Name.ToLower());
        }

        public T Create(T news)
        {
            _collection.InsertOne(news);    
            return news;
        }

        public List<T> Get() => _collection.Find(active => true).ToList();

        public T Get(string id) => _collection.Find<T>(news => news.Id == id).FirstOrDefault();

        public void Remove(string id) => _collection.DeleteOne(news => news.Id == id);

        public void Update(string id, T news) => _collection.ReplaceOne(news => news.Id == id, news);
    }
}
