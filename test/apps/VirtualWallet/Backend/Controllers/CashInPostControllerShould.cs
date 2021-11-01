using Company.Apps.VirtualWallet.Backend;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Respawn;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Company.test.Apps.VirtualWallet.Backend.Controllers
{
    public class CashInPostControllerShould
    {
        private readonly HttpClient _client;

        private readonly Checkpoint _checkpoint = new Checkpoint();

        public CashInPostControllerShould()
        {
            string curDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            var builder = new ConfigurationBuilder()
                .SetBasePath(curDir)
                .AddJsonFile("appsettings.json");
            IWebHostBuilder _webHostBuilder = new WebHostBuilder().UseContentRoot(curDir).UseConfiguration(builder.Build()).UseStartup<Startup>();

            TestServer _server = new TestServer(_webHostBuilder);
            _client = _server.CreateClient();

            IConfigurationRoot _config = builder.Build();

            _checkpoint.Reset(_config["ConnectionStrings:VirtualWalletDatabase"]);
        }

        [Fact]
        public async Task GET_retrieves_weather_forecast() {
            //var response = await _client.GetAsync("/cashin");
            //HttpContent httpContent = new StringContent("{\"name\": \"asdasd\"}", Encoding.UTF8, "application/json");
            HttpContent httpContent = new StringContent("");
            var response = await _client.PostAsync("/cashin?name=asdasd", httpContent);
            response.EnsureSuccessStatusCode();
            //var forecast = JsonConvert.DeserializeObject<WeatherForecast[]>(await response.Content.ReadAsStringAsync());
            //forecast.Should().HaveCount(5);
        }
    }
}
