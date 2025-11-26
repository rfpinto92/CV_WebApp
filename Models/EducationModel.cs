using MongoDB.Bson;

namespace CV_WebApp.Models
{
    public class EducationModel
    {
        public ObjectId _id { get; set; }

        public string Title { get; set; }
        public string SchoolName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }

    }
}
