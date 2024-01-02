namespace Jcf.CursoApiRestFul.Api.Configs
{
    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}