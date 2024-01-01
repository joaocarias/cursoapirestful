namespace Jcf.CursoApiRestFul.Api.Entities
{
    public class News
    {
        public News(string hat, string title, string text, string author, string img, string link, bool active)
        {
            Hat = hat;
            Title = title;
            Text = text;
            Author = author;
            Img = img;
            Link = link;
            PublishDate = DateTime.Now;
            Active = active;
        }

        public string Hat { get; private set; } 

        public string Title { get; private set; }

        public string Text { get; private set; }

        public string Author { get; private set; }

        public string Img { get; private set; }

        public string Link { get; private set; }    

        public DateTime PublishDate { get; private set; }

        public bool Active { get; private set; }
    }
}
