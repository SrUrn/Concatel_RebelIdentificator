using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace RebelIdentificator.IntegrationTests
{
    public class RebelIdentificatorApiIntegrationTest
    {
        [Fact]
        public async Task Test_Get_All()
        {
            var client = new TestClientProvider().Client;

            var response = await client.GetAsync("api/rebelretrive");

            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
