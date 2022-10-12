using FatihBank.Data;
using FatihBank.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using FatihBank.Helpers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

//Data Context
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Mapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddControllersWithViews();
//var mappingConfig = new MapperConfiguration(mc => {
//    mc.AddProfile(new AutoMapperProfile());
//});
//IMapper mapper = mappingConfig.CreateMapper();
//builder.Services.AddSingleton(mapper);
//builder.Services.AddMvc().AddNewtonsoftJson(o =>
//{
//    o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
//});


//MediatR
builder.Services.AddMediatR(typeof(Program));

builder.Services.AddTransient<IUsersRepository, UsersRepository>();
builder.Services.AddTransient<ICustomersRepository, CustomersRepository>();
builder.Services.AddTransient<ICurrenciesRepository, CurrenciesRepository>();
builder.Services.AddTransient<ICommissionRepository, CommissionRepository>();
builder.Services.AddTransient<ICashiersRepository, CashiersRepository>();
builder.Services.AddTransient<IAVGsRepository, AVGsRepository>();
builder.Services.AddTransient<IAccountsRepository, AccountsRepository>();
builder.Services.AddTransient<IChecksRepository, ChecksRepository>();
builder.Services.AddTransient<IEmployeesRepository, EmployeesRepository>();
builder.Services.AddTransient<IDailyAttendanceRepository, DailyAttendanceRepository>();
builder.Services.AddTransient<IDiscountsRepository, DiscountsRepository>();
builder.Services.AddTransient<IExcusesRepository, ExcusesRepository>();
builder.Services.AddTransient<IExcusesTypesRepository, ExcusesTypesRepository>();
builder.Services.AddTransient<IScheduleRepository, ScheduleRepository>();
builder.Services.AddTransient<IMonthInfoRepository, MonthInfoRepository>();
builder.Services.AddTransient<IMonthSalariesRepository, MonthSalariesRepository>();
builder.Services.AddTransient<IRewardsRepository, RewardsRepository>();
builder.Services.AddTransient<IVacationsTypesRepository, VacationsTypesRepository>();
builder.Services.AddTransient<IVacationsRepository, VacationsRepository>();
builder.Services.AddTransient<IExchangeAccountsRepository, ExchangeAccountsRepository>();
builder.Services.AddTransient<IMainAvgRepository, MainAvgRepository>();
builder.Services.AddTransient<IOperationsRepository, OperationsRepository>();
builder.Services.AddTransient<IChatListRepository, ChatListRepository>();
builder.Services.AddTransient<IAddToMonthlyListRepository, AddToMonthlyListRepository>();
builder.Services.AddTransient<IGroupsRepository, GroupsRepository>();
builder.Services.AddTransient<IJournalsRepository, JournalsRepository>();
builder.Services.AddTransient<IJournalsDetailsRepository, JournalsDetailsRepository>();
builder.Services.AddTransient<IMCDRepository, MCDRepository>();
builder.Services.AddTransient<IModulesRepository, ModulesRepository>();
builder.Services.AddTransient<ICountriesRepository, CountriesRepository>();
builder.Services.AddTransient<IStoresRepository, StoresRepository>();
builder.Services.AddTransient<IOrdersRepository, OrdersRepository>();
builder.Services.AddTransient<IPricesRepository, PricesRepository>();
builder.Services.AddTransient<IPermissionsRepository, PermissionsRepository>();
builder.Services.AddTransient<IP_PricesRepository, P_PricesRepository>();
builder.Services.AddTransient<ISMSRepository, SMSRepository>();
builder.Services.AddTransient<ITransactionsRepository, TransactionsRepository>();
builder.Services.AddTransient<IVouchersRepository, VouchersRepository>();
builder.Services.AddTransient<IFavAccountsRepository, FavAccountsRepository>();
builder.Services.AddTransient<IAvgRepository, AvgRepository>();
builder.Services.AddTransient<IActionTypesRepository, ActionTypesRepository>();
builder.Services.AddTransient<INotificationsRepository, NotificationsRepository>();
builder.Services.AddTransient<IRegisterationFileRepository, RegisterationFileRepository>();
builder.Services.AddTransient<IDEF_EmployeesRepository, DEF_EmployeesRepository>();
builder.Services.AddTransient<ICompaniesRepository, CompaniesRepository>();
builder.Services.AddTransient<IIndividualsRepository, IndividualsRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
