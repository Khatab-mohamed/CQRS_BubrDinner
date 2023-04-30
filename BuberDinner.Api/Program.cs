var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    builder.Services
        .AddApplication()
        .AddInfrasturcture(builder.Configuration);

    builder.Services.AddControllers(options =>
        options.Filters.Add<ErrorHandlingFilterAttribute>());

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
    // Configure the HTTP request pipeline.
    // app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseAuthorization();
    app.UseHttpsRedirection();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapControllers();

    app.Run();
}