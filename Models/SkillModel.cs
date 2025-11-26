using MongoDB.Bson;

namespace CV_WebApp.Models
{
    public class SkillModel
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Percent { get; set; }
        public string Level { get; set; }

    }
}
