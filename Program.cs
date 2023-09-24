using BenchmarkDotNet.Running;
using WebApplication3;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:65535");

var app = builder.Build();

var t = Task.Run(() => { app.Run(); });

//Console.ReadKey();
BenchmarkRunner.Run<Benchmarks>();

await app.StopAsync();
await t.WaitAsync(TimeSpan.FromMilliseconds(100));
