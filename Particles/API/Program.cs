using Core.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IParticleService, ParticleServices>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapGet
    (
        "/particles", 
        () => Results.Ok(app.Services.GetRequiredService<IParticleService>().GetParticles())
    )
    .WithName("GetParticles")
    .WithOpenApi();

app.Run();