using CQRSProject.Context;
using CQRSProject.CQRSDesignPattern.Handlers.CategoryHandlers;
using CQRSProject.CQRSDesignPattern.Handlers.ProductHandlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();

builder.Services.AddScoped<GetProductByIdQueryHandler>();
builder.Services.AddScoped<GetProductQueryHandler>();
builder.Services.AddScoped<CreateProductCommandHandler>();
builder.Services.AddScoped<RemoveProductCommandHandler>();
builder.Services.AddScoped<UpdateProductCommandHandler>();

builder.Services.AddDbContext<CQRSContext>();


builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
