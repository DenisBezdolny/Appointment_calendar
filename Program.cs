using Appointment_calendar.Domain.DatabaseAccess;
using Appointment_calendar.Domain.Entities.Concreate;
using Appointment_calendar.Domain.ServicesRepository.Abstract;
using Appointment_calendar.Domain.ServicesRepository.Entity_Framework;
using Appointment_calendar.Models;
using Appointment_calendar.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization(x =>
{
	x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
	x.AddPolicy("TherapistArea", policy => { policy.RequireRole("therapist"); });
});

// Add services to the container.
builder.Services.AddControllersWithViews(x =>
{
	x.Conventions.Add(new AreaAuthorization("Admin", "AdminArea"));
	x.Conventions.Add(new AreaAuthorization("Therapist", "TherapistArea"));
});



//подключаем конфиг из appsetting.json
builder.Configuration.Bind("Project", new BasicInformation());

//подключаем сервисы
builder.Services.AddTransient<ITextFieldsService, EFTextFieldsService>();
builder.Services.AddTransient<IServiceItemService, EFServiceItemsService>();
builder.Services.AddTransient<IClientDataFieldsService, EFClientDataFieldsService>();
builder.Services.AddTransient<IUserService, EFUserService>();
builder.Services.AddTransient<IEventService, EFEventService>();

builder.Services.AddTransient<ServiceManager>();

//registrate db-context
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(BasicInformation.ConnectionString));

builder.Services.AddIdentity<User, IdentityRole>(opts =>
{
	opts.User.RequireUniqueEmail = true;
	opts.Password.RequiredLength = 6;
	opts.Password.RequireNonAlphanumeric = false;
	opts.Password.RequireLowercase = false;
	opts.Password.RequireUppercase = false;
	opts.Password.RequireDigit = false;

}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
	options.Cookie.Name = "PsicoterNat";
	options.ExpireTimeSpan = new TimeSpan(10, 00, 00);
	options.Cookie.MaxAge = TimeSpan.FromDays(1000);
	options.Cookie.SecurePolicy = CookieSecurePolicy.Always; //only HTTPS
	options.Cookie.SameSite = SameSiteMode.Strict; //anti-CSRF, need authentic source
	options.LoginPath = "/account/login";
	options.AccessDeniedPath = "/account/accessdined";
	options.SlidingExpiration = true; //extencion by connection
});


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

app.UseCookiePolicy();
app.UseAuthentication();
app.UseAuthorization();

app.UseAuthorization();


app.MapControllerRoute(
    name: "admin",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "therapist",
    pattern: "therapist/{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
