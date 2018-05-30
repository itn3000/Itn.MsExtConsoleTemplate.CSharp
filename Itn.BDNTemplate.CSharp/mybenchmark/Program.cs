using System;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Configs;

namespace mybenchmark
{
    [Config(typeof(MyBenchmarkConfig))]
    public class MyBenchmarkClass
    {
        [Benchmark]
        public void Bench1()
        {
        }
    }
    class MyBenchmarkConfig : ManualConfig
    {
        public MyBenchmarkConfig()
        {
            Add(Job.Default);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var switcher = new BenchmarkSwitcher(new Type[]
            {
                typeof(MyBenchmarkClass)
            }
            );
            switcher.RunAll();
        }
    }
}
