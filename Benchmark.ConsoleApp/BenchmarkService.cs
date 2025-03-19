using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace Benchmark.ConsoleApp;

public class BenchmarkService
{
    [ShortRunJob, Config(typeof(Config))]
    private class Config: ManualConfig
    {
        public Config()
        {
            SummaryStyle = BenchmarkDotNet.Reports.SummaryStyle.Default.WithRatioStyle(BenchmarkDotNet.Columns.RatioStyle.Trend);
        }
    }


    [Benchmark(Baseline = true)]
    public void GetAll()
    {
        AppDbContext context = new();
        context.Products.ToList();
    }

    [Benchmark]
    public void GetAllSqlRaw()
    {
        AppDbContext context = new();
        context.Products.FromSqlRaw("Select * From Products").ToList();
    }
}
