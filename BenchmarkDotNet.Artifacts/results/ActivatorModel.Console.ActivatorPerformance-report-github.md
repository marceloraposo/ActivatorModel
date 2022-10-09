``` ini

BenchmarkDotNet=v0.13.2, OS=ubuntu 22.04
Intel Core i7-2620M CPU 2.70GHz (Sandy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.109
  [Host]     : .NET 6.0.9 (6.0.922.42201), X64 RyuJIT AVX
  DefaultJob : .NET 6.0.9 (6.0.922.42201), X64 RyuJIT AVX


```
|                               Method |     Mean |     Error |    StdDev |
|------------------------------------- |---------:|----------:|----------:|
| ShouldReturnAnimalActivatorUtilities | 1.065 μs | 0.0203 μs | 0.0376 μs |
|          ShouldReturnAnimalActivator | 1.388 μs | 0.0275 μs | 0.0257 μs |
