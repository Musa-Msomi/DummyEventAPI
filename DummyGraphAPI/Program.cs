using DummyGraphAPI;
using DummyGraphAPI.Helpers;
using DummyGraphAPI.Queries;
using DummyGraphAPI.Service;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(typeof(GetUpcomingEventsQuery).GetTypeInfo().Assembly);

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();



builder.Services.AddScoped<IGraphClient,GraphClient>();
builder.Services.AddTransient<IHelper, Helper>();

builder.Services.AddTransient<IEventService, EventService>();
builder.Services.AddScoped<GraphAPIClientService>();

builder.Services.AddHttpContextAccessor();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
