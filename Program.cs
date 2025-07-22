using hey.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using hey.Data;

namespace hey;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Register services
        builder.Services.AddDbContextFactory<heyContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("heyContext")
            ?? throw new InvalidOperationException("Connection string 'heyContext' not found.")));

        builder.Services.AddQuickGridEntityFrameworkAdapter(); // ✅ moved inside Main
        builder.Services.AddDatabaseDeveloperPageExceptionFilter(); // ✅ moved inside Main

        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        var app = builder.Build();

        // Configure HTTP request pipeline
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
            app.UseMigrationsEndPoint(); // ✅ moved this inside the if block
        }

        app.UseHttpsRedirection();
        app.UseAntiforgery();

        app.MapStaticAssets();
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }
}
