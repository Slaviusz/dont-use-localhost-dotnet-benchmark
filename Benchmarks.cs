#pragma warning disable CS8618
using System.Net;
using BenchmarkDotNet.Attributes;

namespace WebApplication3;

public class Benchmarks {
    private HttpClient _httpClientLocalhost;
    private HttpClient _httpClient127;

    [GlobalSetup]
    public void Setup() {
        var handler1 = new SocketsHttpHandler
        {
            PooledConnectionLifetime = TimeSpan.FromMinutes(5)
        };
        _httpClientLocalhost = new HttpClient(handler1);
        _httpClientLocalhost.BaseAddress = new Uri("http://localhost:65535");

        var handler2 = new SocketsHttpHandler
        {
            PooledConnectionLifetime = TimeSpan.FromMinutes(5)
        };
        _httpClient127 = new HttpClient(handler2);
        _httpClient127.BaseAddress = new Uri("http://127.0.0.1:65535");
    }

    [Benchmark(Baseline = true)]
    public async Task<HttpStatusCode> ConnectToLocalhost() {
        var result = await _httpClientLocalhost.GetAsync("/");
        return result.StatusCode;
    }


    [Benchmark]
    public async Task<HttpStatusCode> ConnectTo127() {
        var result = await _httpClient127.GetAsync("/");
        return result.StatusCode;
    }
}
