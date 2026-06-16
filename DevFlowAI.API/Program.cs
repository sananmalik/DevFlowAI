using DevFlowAI.API.Agents;
using DevFlowAI.API.Data;
using DevFlowAI.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<ProductManagerAgent>();

builder.Services.AddScoped<ArchitectAgent>();

builder.Services.AddScoped<WorkflowService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DeveloperAgent>();

builder.Services.AddScoped<QAAgent>();

builder.Services.AddScoped<ReleaseAgent>();

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