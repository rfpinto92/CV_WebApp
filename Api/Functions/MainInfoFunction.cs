using System.Net;
using Api.Services.Interface;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
namespace Api.Functions
{
    public class MainInfoFunction
    {
        private readonly ILogger _logger;

        private IMongoDB_Service _service { get; set; }

        public MainInfoFunction(ILoggerFactory loggerFactory, IMongoDB_Service service)
        {
            _logger = loggerFactory.CreateLogger<MainInfoFunction>();
            _service = service;
        }

        [Function("MainInfo")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {

            var result = _service!.GetMainInfo();
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.WriteAsJsonAsync(result);

            return response;
        }
    }
}
