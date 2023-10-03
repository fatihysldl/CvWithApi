using BusinessLayer.abstracts;
using BusinessLayer.concrete;
using DataAccessLayer.abstracts;
using DataAccessLayer.concrete;
using DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<context>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IAboutService, aboutManager>();

builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService, contactManager>();

builder.Services.AddScoped<IHeaderDal, EfHeaderDal>();
builder.Services.AddScoped<IHeaderService, headerManager>();

builder.Services.AddScoped<IProjectDal, EfProjectDal>();
builder.Services.AddScoped<IProjectService, projectManager>();


builder.Services.AddScoped<IEducationDal, EfEducationDal>();
builder.Services.AddScoped<IEducationService, educationManager>();

builder.Services.AddScoped<IExperienceDal, EfExperienceDal>();
builder.Services.AddScoped<IExperienceService, exeperienceManager>();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddCors(Opt =>
{
    Opt.AddPolicy("apiCors", Opt =>
    {
        Opt.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

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

app.UseCors("apiCors");

app.UseAuthorization();

app.MapControllers();

app.Run();
