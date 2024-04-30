using Appointment_calendar.Domain.DatabaseAccess;
using Appointment_calendar.Domain.Entities.Concreate;
using Appointment_calendar.Domain.ServicesRepository.Abstract;
using Appointment_calendar.Domain.ServicesRepository.Entity_Framework;
using Appointment_calendar.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//подключаем конфиг из appsetting.json
builder.Configuration.Bind("Project", new BasicInformation());

//подключаем сервисы
builder.Services.AddTransient<ITextFieldsService, EFTextFieldsService>();
builder.Services.AddTransient<IServiceItemService, EFServiceItemsService>();

builder.Services.AddTransient<ServiceManager>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
