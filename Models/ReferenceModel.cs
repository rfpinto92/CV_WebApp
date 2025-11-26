using MongoDB.Bson;

namespace CV_WebApp.Models
{
    public class ReferenceModel
    {
        public ObjectId _id { get; set; }
        public string PersonName { get; set; }
        public string JobTitle { get; set; }
        public string PersonPhoto { get; set; }
        public string ReferenceText { get; set; }
        public string Url { get; set; }
    }
}
