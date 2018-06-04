using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HuliMetrics
{
    public class Metrics
    {
    public async Task<string> SendJson(string service_name, string level)
    {
      var client = new HttpClient();
      var data = new Event() { service_name = service_name, level = level, time = ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds() };
      var dataJson = JsonConvert.SerializeObject(data);
      var response = await client.PostAsync(
        "http://52.47.59.43/event",
        new StringContent(dataJson, Encoding.UTF8, "application/json"));

      string resultJson = dataJson;

      if (response.StatusCode == HttpStatusCode.OK)
      {
        resultJson = await response.Content.ReadAsStringAsync();
        var updated = JsonConvert.DeserializeObject(resultJson);
      }

      return resultJson;
    }
    }
}
