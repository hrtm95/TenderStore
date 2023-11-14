
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TS.Domain.ApplicationServices.AppService;
using TS.Domain.Core.Contracts.ApplicationService;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Entities;
using TS.Domain.Services.Service;
using TS.Endpoints.UI.Models.Maping;
using TS.Infrastructure.Database.SqlServer.Common;
using TS.Infrastructures.DB.Repo.Ef;
using TS.Infrastructures.DB.Repo.Ef.AutoMapping;
using TS.Infrastructures.DB.Repo.Efs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
//    .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAd"));

//builder.Services.AddAuthorization(options =>
//{
//    // By default, all incoming requests will be authorized according to the default policy.
//    options.FallbackPolicy = options.DefaultPolicy;
//});
builder.Services.AddRazorPages();


builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(AutoMapping)));
builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(Map)));

builder.Services.AddDbContext<TSDbcontext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<User, IdentityRole<int>>(
    options =>
    {
        options.SignIn.RequireConfirmedEmail = false;
        options.SignIn.RequireConfirmedPhoneNumber = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Lockout.MaxFailedAccessAttempts = 5;
        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 4;
        options.Password.RequireNonAlphanumeric = false;

    }
    )
.AddEntityFrameworkStores<TSDbcontext>();





// Add Repository
//builder.Services.AddScoped<IAddressRepository, AddressRepository>();
//builder.Services.AddScoped<IAuctionRepository, AuctionRepository>();
//builder.Services.AddScoped<IAuctionInformationRpository, AuctionInformationRpository>();
//builder.Services.AddScoped<IShopStandReposiory, ShopStandReposiory>();
//builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
//builder.Services.AddScoped<ICommentRepository, CommentRepository>();
//builder.Services.AddScoped<ICustomAttributeTemplateRepository, CustomAttributeTemplateRepository>();
//builder.Services.AddScoped<IFixedPriceRepository, FixedPriceRepository>();
//builder.Services.AddScoped<IMedalRepository, MedalRepository>();
//builder.Services.AddScoped<IOrderRepository, OrderRepository>();
//builder.Services.AddScoped<IOrderLineRepository, OrderLineRepository>();
//builder.Services.AddScoped<IOrderStatusRepository, OrderStatusRepository>();
//builder.Services.AddScoped<IPictureRepository, PictureRepository>();
//builder.Services.AddScoped<IProductRepository, ProductRepository>();
//builder.Services.AddScoped<IProductInventoryRepository, ProductInventoryRepository>();
//builder.Services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
//builder.Services.AddScoped<IProductCustomAttributeRepository, ProductCustomAttributeRepository>();
//builder.Services.AddScoped<ISellerRepository, SellerRepository>();
//builder.Services.AddScoped<ISoldRepository, SoldRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


// Add Service
//builder.Services.AddScoped<IAddressService, AddressService>();
//builder.Services.AddScoped<IAuctionPriceService, AuctionService>();
//builder.Services.AddScoped<IAuctionInformationService, AuctionInformationService>();
//builder.Services.AddScoped<IShopStandService, ShopStandService>();
//builder.Services.AddScoped<ICategoryService, CategoryService>();
//builder.Services.AddScoped<ICommentService, CommentService>();
//builder.Services.AddScoped<ICustomAttributeService, CustomAttributeService>();
//builder.Services.AddScoped<IFixedPriceService, FixedPriceService>();
//builder.Services.AddScoped<IMedalService, MedalService>();
//builder.Services.AddScoped<IOrderLineService, OrderLineService>();
//builder.Services.AddScoped<IOrderService, OrderService>();
//builder.Services.AddScoped<IOrderStatusService, OrderStatusService>();
//builder.Services.AddScoped<IPictureService, PictureService>();
//builder.Services.AddScoped<IProductService, ProductService>();
//builder.Services.AddScoped<IProductCategoryService, ProductCategoryService>();
//builder.Services.AddScoped<IProductCustomAttributeService, ProductCustomAttributeService>();
//builder.Services.AddScoped<IProductInventoryService, ProductInventoryService>();
//builder.Services.AddScoped<ISellerService, SellerService>();
//builder.Services.AddScoped<ISoldGoodsService, SoldGoodsService>();
builder.Services.AddScoped<IUserService, UserService>();


// Add AppService
//builder.Services.AddScoped<IAddressApplicationService, AddressApplicationService>();
//builder.Services.AddScoped<IAuctionApplicationService, AuctionApplicationService>();
//builder.Services.AddScoped<IAuctionInformationApplicationService, AuctionInformationApplicationService>();
//builder.Services.AddScoped<IShopStandApplicationService, ShopStandApplicationService>();
//builder.Services.AddScoped<ICategoryApplicationService, CategoryApplicationService>();
//builder.Services.AddScoped<ICommentApplicationService, CommentAppService>();
//builder.Services.AddScoped<ICustomAttributeApplicationService, CustomAttributeApplicationService>();
//builder.Services.AddScoped<IFixedPriceApplicationServicee, FixedPriceApplicationService>();
//builder.Services.AddScoped<IMedalApplicationService, MedalApplicationService>();
//builder.Services.AddScoped<IOrderLineApplicationService, OrderLineApplicationService>();
//builder.Services.AddScoped<IOrderApplicationService, OrderApplicationService>();
//builder.Services.AddScoped<IOrderStatusApplicationService, OrderStatusApplicationService>();
//builder.Services.AddScoped<IPictureApplicationService, PictureApplicationService>();
//builder.Services.AddScoped<IProductApplicationService, ProductApplicationService>();
//builder.Services.AddScoped<IProductCategoryApplicationService, ProductCategoryApplicationService>();
//builder.Services.AddScoped<IProductCustomAttributeApplicationService, ProductCustomAttributeApplicationService>();
//builder.Services.AddScoped<IProductInventoryApplicationService, ProductInventoryApplicationService>();
//builder.Services.AddScoped<ISellerApplicationService, SellerApplicationService>();
//builder.Services.AddScoped<ISoldGoodsApplicationService, SoldGoodsApplicationService>();
builder.Services.AddScoped<IUserApplicationService, UserApplicationService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.MapRazorPages();
app.MapControllers();

app.Run();
