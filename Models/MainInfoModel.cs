using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace CV_WebApp.Models
{
    public class MainInfoModel
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string About_Me { get; set; }
        public string Description { get; set; }
        public string ProfilePhoto { get; set; }
        public string LinkedinAddress { get; set; }
        public string GitUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string Youtube { get; set; }
        public string LinkedinName { get; set; }
        public string CV_Url { get; set; }
    }
}
