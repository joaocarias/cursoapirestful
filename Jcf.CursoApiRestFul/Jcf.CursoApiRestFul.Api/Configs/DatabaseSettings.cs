namespace Jcf.CursoApiRestFul.Api.Configs
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

}
