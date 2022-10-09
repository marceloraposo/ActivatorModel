using BenchmarkDotNet.Running;
namespace ActivatorModel.Console;
class Program
{
    static void Main(string[] args) => BenchmarkRunner.Run<ActivatorPerformance>();
}