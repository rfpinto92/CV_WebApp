using MongoDB.Bson;

namespace CV_WebApp.Models
{
    public class PortfolioModel
    {
        public ObjectId _id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Tecnologies { get; set; }
        public string Url { get; set; }

    }
}
