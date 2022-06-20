using Microsoft.EntityFrameworkCore;
using PhoneBook;
using PhoneBook.Interfaces;
using PhoneBook.Mapper;
using PhoneBook.Services;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<IMapper<PhoneBook.Entities.Contact, PhoneBook.Models.ContactModel>, ContactMapper>();
builder.Services.AddDbContext<PhonebookContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Phonebook")));
var app = builder.Build();



using (var scope = app.Services.CreateScope())
{
    using var dbContext = scope.ServiceProvider.GetRequiredService<PhonebookContext>();
}

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
