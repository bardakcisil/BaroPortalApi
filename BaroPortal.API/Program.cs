using BaroPortal.Business.Abstract;
using BaroPortal.Business.Concrete;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<IUserDal, EfUserDal>();
builder.Services.AddSingleton<INotificationDal, EfNotificationDal>();
builder.Services.AddSingleton<INotificationService, NotificationService>();
builder.Services.AddSingleton<IAdvertDal, EfAdvertDal>();
builder.Services.AddSingleton<IAdvertService, AdvertService>();
builder.Services.AddSingleton<IAnnouncementDal, EfAnnouncementDal>();
builder.Services.AddSingleton<IAnnouncementService, AnnouncementService>();

builder.Services.AddSingleton<IEvenstDal, EfEventsDal>();
builder.Services.AddSingleton<IEventsService, EventService>();

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
