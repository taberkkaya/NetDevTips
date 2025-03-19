﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace AsNoTracking;

public class BenchmarkService
{
    [ShortRunJob, Config(typeof(Config))]
    private class Config : ManualConfig
    {
        public Config()
        {
            SummaryStyle = BenchmarkDotNet.Reports.SummaryStyle.Default.WithRatioStyle(
                BenchmarkDotNet.Columns.RatioStyle.Trend);
        }
    }

    //[Benchmark(Baseline = true)]
    //public void GetAllWithTracking()
    //{
    //    AppDbContext context = new();
    //    context.Products.ToList();
    //}

    //[Benchmark]
    //public void GetAllWithAsNoTracking()
    //{
    //    AppDbContext context = new();
    //    context.Products.AsNoTracking().ToList();
    //}

    [Benchmark(Baseline = true)]
    public void GetFirstWithTracking()
    {
        AppDbContext context = new();
        context.Products.First();
    }

    [Benchmark]
    public void GetFirstWithAsNoTracking()
    {
        AppDbContext context = new();
        context.Products.AsNoTracking().First();
    }
}
