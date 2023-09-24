```

BenchmarkDotNet v0.13.8, macOS Ventura 13.6 (22G120) [Darwin 22.6.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 8.0.100-rc.1.23463.5
  [Host]     : .NET 8.0.0 (8.0.23.41904), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.0 (8.0.23.41904), Arm64 RyuJIT AdvSIMD


```
| Method             | Mean | Error | Ratio | RatioSD |
|------------------- |-----:|------:|------:|--------:|
| ConnectToLocalhost |   NA |    NA |     ? |       ? |
| ConnectTo127       |   NA |    NA |     ? |       ? |

Benchmarks with issues:
  Benchmarks.ConnectToLocalhost: DefaultJob
  Benchmarks.ConnectTo127: DefaultJob
