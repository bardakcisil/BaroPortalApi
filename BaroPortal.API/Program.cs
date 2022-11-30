using BaroPortal.Business.Abstract;
using BaroPortal.Business.Concrete;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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



builder.Services.AddSingleton<IAdvertisementDal, EfAdvertisementDal>();
builder.Services.AddSingleton<IAdvertisementService, AdvertisementService>();

builder.Services.AddSingleton<IAnnouncementDal, EfAnnouncementDal>();
builder.Services.AddSingleton<IAnnouncementService, AnnouncementService>();

builder.Services.AddSingleton<IEventDal, EfEventDal>();
builder.Services.AddSingleton<IEventService, EventService>();

builder.Services.AddSingleton<INewDal, EfNewDal>();
builder.Services.AddSingleton<INewService, NewService>();

builder.Services.AddSingleton<IEducationDal, EfEducationDal>();
builder.Services.AddSingleton<IEducationService, EducationService>();

builder.Services.AddSingleton<IAdvTypeDal, EfAdvTypeDal>();
builder.Services.AddSingleton<IAdvTypeService, AdvTypeService>();



builder.Services.AddSingleton<IBarSearchDal, EfBarSearchDal>();
builder.Services.AddSingleton<IBarSearchService, BarSearchService>();


builder.Services.AddSingleton<IContactUsTopicDal, EfContactUsTopicDal>();
builder.Services.AddSingleton< IContactUsTopicService,ContactUsTopicService>();

builder.Services.AddSingleton<IContactUsDal, EfContactUsDal>();
builder.Services.AddSingleton<IContactUsService, ContactUsService>();

builder.Services.AddSwaggerGen(options => {
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme (\"Bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });


    options.OperationFilter<SecurityRequirementsOperationFilter>();
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
