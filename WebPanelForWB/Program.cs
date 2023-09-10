namespace WebPanelForWB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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
            app.MapControllerRoute("accounts", "accounts/{action}/{id?}", new { controller = "Accounts" });
            app.MapControllerRoute("cards", "cards/{action}/{id?}", new { controller = "Cards" });
            app.MapControllerRoute("delivery", "delivery/{action}/{id?}", new { controller = "Delivery" });
            app.MapControllerRoute("orders", "orders/{action}/{id?}", new { controller = "Orders" });
            app.MapControllerRoute("reviews", "reviews/{action}/{id?}", new { controller = "Reviews" });

            app.Run();
        }
    }
}