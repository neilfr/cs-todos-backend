using System.Runtime.InteropServices.JavaScript;
using cs_todos_backend.Contexts;
using cs_todos_backend.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace Tests;

public class StageControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public StageControllerTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Xunit.Fact]
    public async Task GetEndpointWorks()
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync("/Stage");
        var foo = await response.Content.ReadAsStringAsync();
        var bar = JsonConvert.DeserializeObject<Stage[]>(foo);
        response.EnsureSuccessStatusCode();
        Assert.AreEqual(bar.Length,5);
        Assert.AreEqual(bar[0].Description, "To Do");
    }
    
    [Xunit.Theory]
    [InlineData("/Stage")]
    public async Task ShouldReturnStages(string url)
    {
        // seed stages in the test database
        // how to get context?
        using (var scope = _factory.Services.CreateScope())
        {
            var scopedServices = scope.ServiceProvider;
            var db = scopedServices.GetRequiredService<MyDbContext>();

            var test = new List<Stage>
            {
                new(){ Description = "1"},
                new(){ Description = "2"},
            };
            
            db.Stages.AddRange(test);
            await db.SaveChangesAsync();
        }
        
        // call StageController get (will need to be an http request)
        var client = _factory.CreateClient();
        var response = await client.GetAsync(url);

        // assert it returns the stages
        response.EnsureSuccessStatusCode();

        // How do we assert number of stages in response?
        var thing = 1;
    }
    
}