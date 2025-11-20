using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;

public class TestServerFixture : IDisposable
{
    public HttpClient Client { get; }

    private readonly WebApplicationFactory<Program> _factory;

    public TestServerFixture()
    {
        _factory = new WebApplicationFactory<Program>();
        Client = _factory.CreateClient();
    }

    public void Dispose()
    {
        Client.Dispose();
        _factory.Dispose();
    }
}