namespace Jcf.CursoApiRestFul.Api.Data.Repositories
{
    public interface IMongoRepository<T>
    {
        List<T> Get();
        T Get(string id);
        T Create(T news);
        void Update(string id, T news);
        void Remove(string id);
    }
}
