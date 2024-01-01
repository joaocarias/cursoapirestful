﻿using Jcf.CursoApiRestFul.Api.Entities.Enums;

namespace Jcf.CursoApiRestFul.Api.Entities.ViewModels
{
    public class NewsViewModel
    {
        public string Hat { get; set; }
           
        public string Title { get; set; }
              
        public string Text { get; set; }
                
        public string Author { get; set; }
               
        public string Img { get; set; }
                
        public string Link { get; set; }
                
        public DateTime PublishDate { get; set; }
                
        public EStatusType Status { get; set; }
    }
}
