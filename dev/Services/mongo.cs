using dev.Models;
using MongoDB.Driver;
using System.Text.Json;

namespace dev.Services
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

            var a = JsonSerializer.Deserialize<List<Skill>>(result);

            return a;

        }
    }
}
