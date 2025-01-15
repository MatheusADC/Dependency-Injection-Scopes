using DependencyInjectionTest.UseCase.Scoped;
using DependencyInjectionTest.UseCase.Singleton;
using DependencyInjectionTest.UseCase.Transient;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<SingletonUseCase>();
builder.Services.AddTransient<TransientUseCase>();
builder.Services.AddScoped<ScopedUseCase>();
builder.Services.AddScoped<UseCaseA>();
builder.Services.AddScoped<UseCaseB>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
