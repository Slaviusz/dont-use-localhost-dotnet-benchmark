```

BenchmarkDotNet v0.13.8, macOS Ventura 13.6 (22G120) [Darwin 22.6.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 8.0.100-rc.1.23463.5
  [Host]     : .NET 8.0.0 (8.0.23.41904), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.0 (8.0.23.41904), Arm64 RyuJIT AdvSIMD


```
| Method             | Mean     | Error    | StdDev   | Ratio | RatioSD |
|------------------- |---------:|---------:|---------:|------:|--------:|
| ConnectToLocalhost | 73.37 μs | 1.463 μs | 2.404 μs |  1.00 |    0.00 |
| ConnectTo127       | 73.43 μs | 1.396 μs | 2.518 μs |  1.00 |    0.05 |
