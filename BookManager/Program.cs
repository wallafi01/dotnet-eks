using BookManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<MongoDBConfig>(builder.Configuration.GetSection("MongoDBConfig"));
builder.Services.AddScoped<BookService>();
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

// var builder = WebApplication.CreateBuilder(args);

// // Configurar portas HTTP e HTTPS explicitamente para Kestrel
// builder.WebHost.ConfigureKestrel(options =>
// {
//     options.ListenAnyIP(5001); // Porta HTTP
//     options.ListenAnyIP(7001, listenOptions =>
//     {
//         listenOptions.UseHttps(); // Porta HTTPS
//     });
// });

// // Add services to the container.
// builder.Services.Configure<MongoDBConfig>(builder.Configuration.GetSection("MongoDBConfig"));
// builder.Services.AddScoped<BookService>();
// builder.Services.AddControllers();
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection(); // Redirecionar HTTP para HTTPS

// app.UseAuthorization();

// app.MapControllers();

// app.Run();

