﻿using AutoMapper;
using Jcf.CursoApiRestFul.Api.Data.Repositories;
using Jcf.CursoApiRestFul.Api.Entities;
using Jcf.CursoApiRestFul.Api.Entities.ViewModels;

namespace Jcf.CursoApiRestFul.Api.Services
{
    public class NewsService
    {
        private readonly IMapper _mapper;
        private readonly IMongoRepository<News> _news;

        public NewsService(IMapper mapper, IMongoRepository<News> news)
        {
            _mapper = mapper;
            _news = news;
        }

        public List<NewsViewModel> Get() => 
            _mapper.Map<List<NewsViewModel>>(_news.Get().ToList());

        public NewsViewModel Get(string id) =>
            _mapper.Map<NewsViewModel>(_news.Get(id));

        public NewsViewModel Create(NewsViewModel news)
        {
            var entity = new News(news.Hat, news.Title, news.Text, news.Author, news.Img, news.Link, news.Status);
            _news.Create(entity);   

            return Get(entity.Id);
        }

        public void Update(string id, NewsViewModel news) 
        {
            _news.Update(id, _mapper.Map<News>(news));
        }

        public void Remove(string id) => _news.Remove(id);
    }
}
