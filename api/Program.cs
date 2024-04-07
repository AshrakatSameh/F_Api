using api;
using api.IdentityServices;
using api.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<LetterDBContext>();

builder.Services.AddScoped<IDeptService, DeptService>();
builder.Services.AddScoped<ISubLetterService, SubLetterService>();
builder.Services.AddScoped<IExLetterService, ExLetterService>();
builder.Services.AddScoped<IMainLetterService, MainLetterService>();
builder.Services.AddScoped<ILetterExService, LetterExService>();
builder.Services.AddScoped<ISubExService, SubExService>();
builder.Services.AddScoped<IMainEx, MainExService>();
builder.Services.AddScoped<IEmpService, EmpService>();


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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
