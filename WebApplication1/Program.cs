using MediatR;
using WebApplication1.Controllers.WithoutMediatr;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var serviceProvider = new ServiceCollection()
		.AddTransient<IRequestHandler<Magic, string>, MagicHandler>()
		.BuildServiceProvider();

builder.Services.AddTransient<ISimple, SimpleImpl>(); // This is needed for other dependencies

//var mediator = new Mediator(serviceProvider);

// Register MediatR handlers
builder.Services.AddMediatR(cfg => {
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
