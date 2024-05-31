using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace dev.Models
{
    public class MainInfo
    {
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
    }
}
