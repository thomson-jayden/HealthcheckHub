using Microsoft.Extensions.Logging;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Azure.Functions.Worker;
using System.Diagnostics;
using System.Net;

namespace HealthcheckHub.Functions;

public class HealthcheckHubFunction
{

    public HealthcheckHubFunction()
    {

    }

    [Function(nameof(HealthcheckHubFunction))]
    public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequestData req, FunctionContext executionContext)
    {

        var response = req.CreateResponse(HttpStatusCode.OK);

        response.Headers.Add("Date", "Mon, 18 Jul 2016 16:06:00 GMT");
        response.Headers.Add("Content-Type", "text/html; charset=utf-8");
        response.WriteString("Hello world!");

        return response;
    }
}
