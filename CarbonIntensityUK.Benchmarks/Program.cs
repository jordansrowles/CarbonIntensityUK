using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using CarbonIntensityUK.Controllers;
using CarbonIntensityUK.Models;
using CarbonIntensityUK.Models.ValueTypes;

namespace CarbonIntensityUK.Benchmarks
{

    public class BasicBenchmark
    {
        List<GenerationMixResponse> generationMixResponses = new List<GenerationMixResponse>();
        List<GenerationMixResponseValue> generationMixResponseValues = new();

        public BasicBenchmark()
        {
            GetData().Wait();
        }

        async Task GetData()
        {
            var start = DateTime.Now.AddDays(-10);
            var end = DateTime.Now;

            generationMixResponses = await NationalGeneration.Get(start, end);
            generationMixResponseValues = await NationalGeneration.GetAsValue(start, end);
        }

        [Benchmark]
        public void TestClasses()
        {
            foreach (var response in generationMixResponses)
            {
                response.GenerationMix.Order();
            }
        }

        [Benchmark]
        public void TestRecordStructs()
        {
            foreach (var res in generationMixResponseValues)
            {
                res.GenerationMix.Order();
            }
        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BasicBenchmark>();
        }
    }
}
