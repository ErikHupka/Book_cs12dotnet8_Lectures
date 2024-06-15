using Microsoft.AspNetCore.Mvc.Formatters; // To use IOutputFormatter
using Northwind.EntityModels; // To use AddNorthwindContextmethod
using Microsoft.Extensions.Caching.Memory; // To use IMemoryCache and so on.
using Northwind.WebApi.Repositories; // To use ICustomerRepository
using Swashbuckle.AspNetCore.SwaggerUI; // To use SubmitMethod.
using Microsoft.AspNetCore.HttpLogging; // To use HttpLoggingFields

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = HttpLoggingFields.All;
    options.RequestBodyLogLimit = 4096; // Default is 32k.
    options.ResponseBodyLogLimit = 4096; // Default is 32k.
});

// Add services to the container.

builder.Services.AddSingleton<IMemoryCache>(
    implementationInstance: new MemoryCache(optionsAccessor: new MemoryCacheOptions()));
builder.Services.AddNorthwindContext();
builder.Services.AddControllers(options =>
{
    WriteLine("Default output formatters:");
    foreach (IOutputFormatter formatter in options.OutputFormatters)
    {
        OutputFormatter? mediaFormatter = formatter as OutputFormatter;
        if (mediaFormatter is null)
        {
            WriteLine(value: $"{formatter.GetType().Name}");
        }
        else // OutputFormatter class has SUpported MediaTypes
        {
            WriteLine(value: $"{mediaFormatter.GetType().Name}, Media types: {string.Join(",", mediaFormatter.SupportedMediaTypes)}");
        }
    }
})
    .AddXmlDataContractSerializerFormatters()
    .AddXmlSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

var app = builder.Build();

app.UseHttpLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json",
            "Northwind Service API Version 1");
        c.SupportedSubmitMethods(new[]
        {
            SubmitMethod.Get, SubmitMethod.Post,
            SubmitMethod.Put, SubmitMethod.Delete
        });
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
