public class Startup
{
 public Startup(IConfiguration configuration, IWebHostEnvironment env)
 {
 Environment = env;
 Configuration = configuration;
 }
 public IConfiguration Configuration { get; }
 public IWebHostEnvironment Environment { get; }
 public void ConfigureServices(IServiceCollection services)
  services.AddRazorPages();
 services.AddDbContext<RazorPagesMovieContext>(options =>

options.UseSqlite(Configuration.GetConnectionString("RazorPagesMovieContext")));
}
 else
 {
 services.AddDbContext<RazorPagesMovieContext>(options =>
 options.UseSqlServer(
 Configuration.GetConnectionString("MovieContext")));
 }
 services.AddRazorPages();
 }
 public void Configure(IApplicationBuilder app)
 {
 if (Environment.IsDevelopment())
 {
 app.UseDeveloperExceptionPage();
 }
 else
 {
 app.UseExceptionHandler("/Error");
 app.UseHsts();
 }
 app.UseHttpsRedirection();
 app.UseStaticFiles();
 app.UseRouting();
 app.UseEndpoints(endpoints =>
 {
 endpoints.MapRazorPages();
 });
 }
}
