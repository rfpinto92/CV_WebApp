using System.Net;
using Api.Services.Interface;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
namespace Api.Functions;

public class EducationFunction
{
    private readonly ILogger _logger;

    private IMongoDB_Service _service { get; set; }

    public EducationFunction(ILoggerFactory loggerFactory, IMongoDB_Service service)
    {
        _logger = loggerFactory.CreateLogger<EducationFunction>();
        _service = service;
    }

    [Function("Education")]
    public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
    {

        var result = _service!.GetEducation();
        var response = req.CreateResponse(HttpStatusCode.OK);
        response.WriteAsJsonAsync(result);

        return response;
    }

}