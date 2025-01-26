using Microsoft.EntityFrameworkCore;
using MyLearnFuture.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
{
    options.SuppressAsyncSuffixInActionNames = false;
});

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalConnection"), b => b.MigrationsAssembly("MyLearnFuture.API")));

//builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi(); ?
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();


