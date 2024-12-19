using RPinto.Models;
using MongoDB.Driver;
using System.Text.Json;

namespace RPinto.Services
{
    public class MongoDB_Service
    {

        public async Task<MainInfo> GetMainInfo()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://eu-west-2.aws.data.mongodb-api.com/app/application-0-wumjgid/endpoint/person");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<MainInfo>(result);
        }

        public async Task<List<Skill>> GetSkills()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://eu-west-2.aws.data.mongodb-api.com/app/application-0-wumjgid/endpoint/skills");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Skill>>(result);

        }

        public async Task<List<WorkExperience>> GetWorkExperience()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://eu-west-2.aws.data.mongodb-api.com/app/application-0-wumjgid/endpoint/workexperience");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<WorkExperience>>(result);
        }


        public async Task<List<Education>> GetEducation()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://eu-west-2.aws.data.mongodb-api.com/app/application-0-wumjgid/endpoint/education");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Education>>(result);
        }

        public async Task<List<Portfolio>> GetPortfolio()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://eu-west-2.aws.data.mongodb-api.com/app/application-0-wumjgid/endpoint/porfolio");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Portfolio>>(result);
        }

        public async Task<List<Reference>> GetReferences()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://eu-west-2.aws.data.mongodb-api.com/app/application-0-wumjgid/endpoint/reference");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Reference>>(result);
        }

    }
}
