
using PackagesManagement;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using AngleSharp;
using AngleSharp.Html.Parser;

namespace PackagesManagementTest
{
    public class UIExampleTestcs:
         IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly
            WebApplicationFactory<Program> _factory;
        public UIExampleTestcs(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task TestMenu()
        {
            var client = _factory.CreateClient();
            
            //Create an angleSharp default configuration
            var config = Configuration.Default;

            //Create a new context for evaluating webpages 
            //with the given config
            var context = BrowsingContext.New(config);

            var response = await client.GetAsync("/");
            response.EnsureSuccessStatusCode();
            string source = await response.Content.ReadAsStringAsync();
            var document = await context.OpenAsync(req =>
                req.Content(source));
            var node = document.QuerySelector("a[href=\"/ManagePackages\"]");   

            Assert.NotNull(node);
        }
    }
}
