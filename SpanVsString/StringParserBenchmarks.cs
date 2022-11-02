// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

[RankColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[MemoryDiagnoser]
public class StringParserBenchmarks
{
    private const string FullName = "Abdul Rahman";
    private static readonly StringParser Parser = new();

    [Benchmark(Baseline = true)]
    public void GetFirstName()
    {
        Parser.GetFirstName(FullName);
    }

    [Benchmark]
    public void GetFirstNameUsingSubstring()
    {
        Parser.GetFirstNameUsingSubstring(FullName);
    }

    [Benchmark]
    public void GetFirstNameWithSpan()
    {
        Parser.GetFirstNameWithSpan(FullName);
    }
}
