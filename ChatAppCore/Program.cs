using ChatAppCore.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache(); // Required for session
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});

// Singleton chat message store simulating Application state
builder.Services.AddSingleton<ChatMessageStore>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseSession(); // Enable session
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
