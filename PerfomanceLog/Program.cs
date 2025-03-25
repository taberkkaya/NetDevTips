using System.Diagnostics;
using DataAccess.Context;
using DataAccess.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Use(async (context, next) =>
{
    var stopwatch = new Stopwatch();
    stopwatch.Start();
    AppDbContext _context = new();
    PerfomanceLog perfomanceLog = new()
    {
        MethodName = context.Request.Path.Value,
        StartingDate = DateTime.Now
    };

    await next(context);

    perfomanceLog.EndDate = DateTime.Now;
    perfomanceLog.TransactionTimeInSecond = (int)stopwatch.Elapsed.TotalSeconds;
    perfomanceLog.TransactionTimeInMilisecond = (int)stopwatch.Elapsed.TotalMilliseconds;
    await _context.AddAsync(perfomanceLog);
    await _context.SaveChangesAsync();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
