using AutoMapper;
using FatihBank.Models;
using FatihBank.DTOs;
using FatihBank.Features.MSS_DEF_UsersFeatures.Commands;
using FatihBank.Features.MSS_DEF_CustomersFeatures.Commands;
using FatihBank.Features.MSS_DEF_CurrenciesFeatures.Commands;
using FatihBank.Features.MSS_DEF_CommissionFeatures.Commands;
using FatihBank.Features.MSS_DEF_CashiersFeatures.Commands;
using FatihBank.Features.MSS_DEF_AVGsFeatures.Commands;
using FatihBank.Features.ChecksFeatures.Commands;
using FatihBank.Features.EmployeesFeatuers.Commands;
using FatihBank.Features.AccountsFeatures.Commands;
using FatihBank.Features.DailyAttendanceFeatures.Commands;
using FatihBank.Features.DiscountsFeatures.Commands;
using FatihBank.Features.ExcusesFeatures.Commands;
using FatihBank.Features.ExcusesTypesFeatures.Commands;
using FatihBank.Features.ScheduleFeatures.Commands;
using FatihBank.Features.MonthInfoFeatures.Commands;
using FatihBank.Features.MonthSalariesFeatures.Commands;
using FatihBank.Features.RewardsFeatures.Commands;
using FatihBank.Features.VacationsTypesFeatures.Commands;
using FatihBank.Features.VacationsFeatures.Commands;
using FatihBank.Features.ExchangeAccountsFeatures.Commands;
using FatihBank.Features.MainAvgFeatures.Commands;
using FatihBank.Features.OperationsFeatures.Commands;
using FatihBank.Features.ChatListFeatures.Commands;
using FatihBank.Features.MonthlyListFeatures.Commands;
using FatihBank.Features.GroupsFeatures.Commands;
using FatihBank.Features.JournalsFeatures.Commands;
using FatihBank.Features.MCDFeatures.Commands;
using FatihBank.Features.ModulesFeatures.Commands;
using FatihBank.Features.CountriesFeatures.Commands;
using FatihBank.Features.StoresFeatures.Commands;
using FatihBank.Features.OrdersFeatures.Commands;
using FatihBank.Features.PricesFeatures.Commands;
using FatihBank.Features.PermissionsFeatures.Commands;
using FatihBank.Features.P_PricesFeatures.Commands;
using FatihBank.Features.SMSFeatures.Commands;
using FatihBank.Features.TransactionsFeatures.Commands;
using FatihBank.Features.VouchersFeatures.Commands;
using FatihBank.Features.FavAccountsFeatures.Commands;
using FatihBank.Features.AvgFeatures.Commands;
using FatihBank.Features.ActionTypesFeatures.Commands;
using FatihBank.Features.NotificationsFeatures.Commands;
using FatihBank.Features.RegisterationFileFeatures.Commands;
using FatihBank.Features.DEF_EmployeesFeatures.Commands;
using FatihBank.Features.CompaniesFeatures.Commands;
using FatihBank.Features.IndividualsFeatures.Commands;

namespace FatihBank.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<int?, int>().ConvertUsing((src, dest) => src ?? dest);
            //CreateMap<double?, double>().ConvertUsing((src, dest) => src ?? dest);
            //CreateMap<Test, TestDto>().ReverseMap().MaxDepth(2).ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            
            //MSS_DEF_Accounts
            CreateMap<MSS_DEF_Accounts, AccountsDto>().ReverseMap().MaxDepth(2).ForAllMembers(opts => opts.Condition((src, dest, srcMember) =>(srcMember != null)));
            CreateMap<AddAccountsCommand, AccountsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateAccountsCommand, AccountsDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Users
            CreateMap<MSS_DEF_Users, UsersDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddUsersCommand, UsersDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateUsersCommand, UsersDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Customers
            CreateMap<MSS_DEF_Customers, CustomersDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddCustomersCommand, CustomersDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateCustomersCommand, CustomersDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Currencies
            CreateMap<MSS_DEF_Currencies, CurrenciesDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddCurrenciesCommand, CurrenciesDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateCurrenciesCommand, CurrenciesDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Commission
            CreateMap<MSS_DEF_Commission, CommissionDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddCommissionCommand, CommissionDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateCommissionCommand, CommissionDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Cashiers
            CreateMap<MSS_DEF_Cashiers, CashiersDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddCashiersCommand, CashiersDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateCashiersCommand, CashiersDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_AVGs
            CreateMap<MSS_DEF_AVGs, AVGsDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddAVGsCommand, AVGsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateAVGsCommand, AVGsDto>().ReverseMap().MaxDepth(2);

            

            //MSS_ACC_Checks
            CreateMap<MSS_ACC_Checks, ChecksDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddChecksCommand, ChecksDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateChecksCommand, ChecksDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Employees
            CreateMap<MSS_DEF_Employees, EmployeesDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddEmployeesCommand, EmployeesDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateEmployeesCommand, EmployeesDto>().ReverseMap().MaxDepth(2);

            //MSS_ATT_Daily_Attendance
            CreateMap<MSS_ATT_Daily_Attendance, DailyAttendanceDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddDailyAttendanceCommand, DailyAttendanceDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateDailyAttendanceCommand, DailyAttendanceDto>().ReverseMap().MaxDepth(2);

            //MSS_ATT_Discounts
            CreateMap<MSS_ATT_Discounts, DiscountsDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddDiscountsCommand, DiscountsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateDiscountsCommand, DiscountsDto>().ReverseMap().MaxDepth(2);

            //MSS_ATT_Excuses
            CreateMap<MSS_ATT_Excuses, ExcusesDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddExcusesCommand, ExcusesDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateExcusesCommand, ExcusesDto>().ReverseMap().MaxDepth(2);

            //MSS_ATT_ExcusesTypes
            CreateMap<MSS_ATT_ExcusesTypes, ExcusesTypesDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddExcusesTypesCommand, ExcusesTypesDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateExcusesTypesCommand, ExcusesTypesDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Schedule
            CreateMap<MSS_DEF_Schedule, ScheduleDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddScheduleCommand, ScheduleDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateScheduleCommand, ScheduleDto>().ReverseMap().MaxDepth(2);

            //MSS_ATT_Month_Info
            CreateMap<MSS_ATT_Month_Info, MonthInfoDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddMonthInfoCommand, MonthInfoDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateMonthInfoCommand, MonthInfoDto>().ReverseMap().MaxDepth(2);

            //MSS_ATT_Month_Salaries
            CreateMap<MSS_ATT_Month_Salaries, MonthSalariesDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddMonthSalariesCommand, MonthSalariesDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateMonthSalariesCommand, MonthSalariesDto>().ReverseMap().MaxDepth(2);

            //MSS_ATT_Rewards
            CreateMap<MSS_ATT_Rewards, RewardsDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddRewardsCommand, RewardsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateRewardsCommand, RewardsDto>().ReverseMap().MaxDepth(2);

            //MSS_ATT_VacationsTypes
            CreateMap<MSS_ATT_VacationsTypes, VacationsTypesDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddVacationsTypesCommand, VacationsTypesDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateVacationsTypesCommand, VacationsTypesDto>().ReverseMap().MaxDepth(2);

            //MSS_ATT_Vacations
            CreateMap<MSS_ATT_Vacations, VacationsDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddVacationsCommand, VacationsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateVacationsCommand, VacationsDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Exchange_Accounts
            CreateMap<MSS_DEF_Exchange_Accounts, ExchangeAccountsDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddExchangeAccountsCommand, ExchangeAccountsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateExchangeAccountsCommand, ExchangeAccountsDto>().ReverseMap().MaxDepth(2);

            //MSS_AVG_MainAvg
            CreateMap<MSS_AVG_MainAvg, MainAvgDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddMainAvgCommand, MainAvgDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateMainAvgCommand, MainAvgDto>().ReverseMap().MaxDepth(2);

            //MSS_CAS_Operations
            CreateMap<MSS_CAS_Operations, OperationsDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddOperationsCommand, OperationsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateOperationsCommand, OperationsDto>().ReverseMap().MaxDepth(2);

            //MSS_CHT_ChatList
            CreateMap<MSS_CHT_ChatList, ChatListDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddChatListCommand, ChatListDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateChatListCommand, ChatListDto>().ReverseMap().MaxDepth(2);

            //MSS_CUS_Add_To_Monthly_List
            CreateMap<MSS_CUS_Add_To_Monthly_List, AddToMonthlyListDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddToMonthlyListCommand, AddToMonthlyListDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateToMonthlyListCommand, AddToMonthlyListDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Groups
            CreateMap<MSS_DEF_Groups, GroupsDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddGroupsCommand, GroupsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateGroupsCommand, GroupsDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Journals
            CreateMap<MSS_DEF_Journals, JournalsDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddJournalsCommand, JournalsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateJournalsCommand, JournalsDto>().ReverseMap().MaxDepth(2);

            //MSS_JOU_Details
            CreateMap<MSS_JOU_Details, JournalsDetailsDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddJournalsDetailsCommand, JournalsDetailsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateJournalsDetailsCommand, JournalsDetailsDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_MCD
            CreateMap<MSS_DEF_MCD, MCDDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddMCDCommand, MCDDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateMCDCommand, MCDDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Modules
            CreateMap<MSS_DEF_Modules, ModulesDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddModulesCommand, ModulesDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateModulesCommand, ModulesDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Countries
            CreateMap<MSS_DEF_Countries, CountriesDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddCountriesCommand, CountriesDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateCountriesCommand, CountriesDto>().ReverseMap().MaxDepth(2);
            //MSS_DEF_Stores
            CreateMap<MSS_DEF_Stores, StoresDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddStoresCommand, StoresDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateStoresCommand, StoresDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Orders
            CreateMap<MSS_DEF_Orders, OrdersDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddOrdersCommand, OrdersDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateOrdersCommand, OrdersDto>().ReverseMap().MaxDepth(2);


            //MSS_DEF_Prices
            CreateMap<MSS_DEF_Prices, PricesDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddPricesCommand, PricesDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdatePricesCommand, PricesDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Permissions
            CreateMap<MSS_DEF_Permissions, PermissionsDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddPermissionsCommand, PermissionsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdatePermissionsCommand, PermissionsDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_P_Prices
            CreateMap<MSS_DEF_P_Prices, P_PricesDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddP_PricesCommand, P_PricesDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateP_PricesCommand, P_PricesDto>().ReverseMap().MaxDepth(2);


            //MSS_DEF_SMS
            CreateMap<MSS_DEF_SMS, SMSDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddSMSCommand, SMSDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateSMSCommand, SMSDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Transactions
            CreateMap<MSS_DEF_Transactions, TransactionsDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddTransactionsCommand, TransactionsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateTransactionsCommand, TransactionsDto>().ReverseMap().MaxDepth(2);

            //MSS_DEF_Vouchers
            CreateMap<MSS_DEF_Vouchers, VouchersDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddVouchersCommand, VouchersDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateVouchersCommand, VouchersDto>().ReverseMap().MaxDepth(2);

            //MSS_FAV_FavAccounts
            CreateMap<MSS_FAV_FavAccounts, FavAccountsDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddFavAccountsCommand, FavAccountsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateFavAccountsCommand, FavAccountsDto>().ReverseMap().MaxDepth(2);

            //MSS_FIN_Avg
            CreateMap<MSS_FIN_Avg, AvgDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddAvgCommand, AvgDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateAvgCommand, AvgDto>().ReverseMap().MaxDepth(2);

            //MSS_INF_Action_Types
            CreateMap<MSS_INF_Action_Types, ActionTypesDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddActionTypesCommand, ActionTypesDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateActionTypesCommand, ActionTypesDto>().ReverseMap().MaxDepth(2);

            //MSS_INF_Notifications
            CreateMap<MSS_INF_Notifications, NotificationsDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddNotificationsCommand, NotificationsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateNotificationsCommand, NotificationsDto>().ReverseMap().MaxDepth(2);

            //MSS_INF_RegisterationFile
            CreateMap<MSS_INF_RegisterationFile, RegisterationFileDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddRegisterationFileCommand, RegisterationFileDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateRegisterationFileCommand, RegisterationFileDto>().ReverseMap().MaxDepth(2);

            //MSS_N_DEF_Employees
            CreateMap<MSS_N_DEF_Employees, DEF_EmployeesDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddDEF_EmployeesCommand, DEF_EmployeesDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateDEF_EmployeesCommand, DEF_EmployeesDto>().ReverseMap().MaxDepth(2);

            //MSS_TRS_Companies
            CreateMap<MSS_TRS_Companies, CompaniesDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddCompaniesCommand, CompaniesDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateCompaniesCommand, CompaniesDto>().ReverseMap().MaxDepth(2);

            //MSS_TRS_Individuals
            CreateMap<MSS_TRS_Individuals, IndividualsDto>().ReverseMap().MaxDepth(2);
            CreateMap<AddIndividualsCommand, IndividualsDto>().ReverseMap().MaxDepth(2);
            CreateMap<UpdateIndividualsCommand, IndividualsDto>().ReverseMap().MaxDepth(2);
        }
    }
}
