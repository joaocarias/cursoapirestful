using Jcf.CursoApiRestFul.Api.Entities.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace Jcf.CursoApiRestFul.Api.Entities
{
    public class News : BaseEntity
    {
        public News(string hat, string title, string text, string author, string img, string link, EStatusType status)
        {
            Hat = hat;
            Title = title;
            Text = text;
            Author = author;
            Img = img;
            Link = link;
            PublishDate = DateTime.Now;
            Status = status;
        }

        public EStatusType ChangeStatus(EStatusType status)
        {
            switch (status)
            {
                case EStatusType.Active:
                    status = EStatusType.Active; 
                    break;
                case EStatusType.Inactive:
                    status = EStatusType.Inactive;
                    break;
                case EStatusType.Draft:
                    status = EStatusType.Draft;
                    break;
            }

            return status;
        }

        [BsonElement("hat")]
        public string Hat { get; private set; }

        [BsonElement("title")]
        public string Title { get; private set; }

        [BsonElement("text")]
        public string Text { get; private set; }

        [BsonElement("author")]
        public string Author { get; private set; }

        [BsonElement("img")]
        public string Img { get; private set; }

        [BsonElement("link")]
        public string Link { get; private set; }

        [BsonElement("publishDate")]
        public DateTime PublishDate { get; private set; }

        [BsonElement("active")]
        public EStatusType Status { get; private set; }
    }
}
