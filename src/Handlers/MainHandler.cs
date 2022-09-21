using HealthcheckHub.Models;
using Microsoft.Azure.Functions.Worker.Http;
using System.Threading.Tasks;

namespace HealthcheckHub.Handlers;

public class MainHandler
{
    public Task<HttpResponseData> ProcessAsync(HttpRequestData request)
    {
        return null;
    }
}
