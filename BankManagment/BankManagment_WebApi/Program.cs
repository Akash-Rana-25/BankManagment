using BankManagment_Infrastructure.Context;
using BankManagment_Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Reflection;
using BankManagment_DependencyInjectionExtensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlServerOptionsAction: sqlOptions =>
        {
            sqlOptions.MigrationsAssembly("BankManagment_Migration");
        });
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.RegisterServicesAndRepositories(Assembly.GetExecutingAssembly());

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    // Use the exception handler middleware for non-development environments.
    app.UseExceptionHandler(errorApp =>
    {
        errorApp.Run(async context =>
        {
            var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
            var exception = exceptionHandlerPathFeature.Error;

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = 500; // Internal Server Error

            // Return an error response to the client.
            await context.Response.WriteAsync(JsonConvert.SerializeObject(new
            {
                message = "An error occurred.",
                exception = exception.Message 
            }));
        });
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
