using AutoMapper;
using Jcf.CursoApiRestFul.Api.Entities;
using Jcf.CursoApiRestFul.Api.Entities.ViewModels;

namespace Jcf.CursoApiRestFul.Api.Configs
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        { 
            CreateMap<News, NewsViewModel>().ReverseMap();  
        }
    }
}
