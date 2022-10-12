using Microsoft.EntityFrameworkCore;
using FatihBank.Models;

namespace FatihBank.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        
        public DbSet<MSS_DEF_Users> MSS_DEF_Users { get; set; }
        public DbSet<MSS_DEF_Currencies> MSS_DEF_Currencies { get; set; }
        public DbSet<MSS_DEF_Customers> MSS_DEF_Customers { get; set; }
        public DbSet<MSS_DEF_Accounts> MSS_DEF_Accounts { get; set; }
        public DbSet<MSS_DEF_Cashiers> MSS_DEF_Cashiers { get; set; }
        public DbSet<MSS_DEF_Commission> MSS_DEF_Commission { get; set; }
        public DbSet<MSS_DEF_AVGs> MSS_DEF_AVGs { get; set; }
        public DbSet<MSS_ACC_Checks> MSS_ACC_Checks { get; set; }
        public DbSet<MSS_DEF_Employees> MSS_DEF_Employees { get; set; }
        public DbSet<MSS_ATT_Daily_Attendance> MSS_ATT_Daily_Attendance { get; set; }
        public DbSet<MSS_ATT_Discounts> MSS_ATT_Discounts { get; set; }
        public DbSet<MSS_ATT_Excuses> MSS_ATT_Excuses { get; set; }
        public DbSet<MSS_ATT_ExcusesTypes> MSS_ATT_ExcusesTypes { get; set; }
        public DbSet<MSS_DEF_Schedule> MSS_DEF_Schedule { get; set; }
        public DbSet<MSS_ATT_Month_Info> MSS_ATT_Month_Info { get; set; }
        public DbSet<MSS_ATT_Month_Salaries> MSS_ATT_Month_Salaries { get; set; }
        public DbSet<MSS_ATT_Rewards> MSS_ATT_Rewards { get; set; }
        public DbSet<MSS_ATT_VacationsTypes> MSS_ATT_VacationsTypes { get; set; }
        public DbSet<MSS_ATT_Vacations> MSS_ATT_Vacations { get; set; }
        public DbSet<MSS_DEF_Exchange_Accounts> MSS_DEF_Exchange_Accounts { get; set; }
        public DbSet<MSS_AVG_MainAvg> MSS_AVG_MainAvg { get; set; }
        public DbSet<MSS_CAS_Operations> MSS_CAS_Operations { get; set; }
        public DbSet<MSS_CHT_ChatList> MSS_CHT_ChatList { get; set; }
        public DbSet<MSS_CUS_Add_To_Monthly_List> MSS_CUS_Add_To_Monthly_List { get; set; }
        public DbSet<MSS_DEF_Groups> MSS_DEF_Groups { get; set; }
        public DbSet<MSS_DEF_Journals> MSS_DEF_Journals { get; set; }
        public DbSet<MSS_JOU_Details> MSS_JOU_Details { get; set; }
        public DbSet<MSS_DEF_MCD> MSS_DEF_MCD { get; set; }
        public DbSet<MSS_DEF_Modules> MSS_DEF_Modules { get; set; }
        public DbSet<MSS_DEF_Countries> MSS_DEF_Countries { get; set; }
        public DbSet<MSS_DEF_Stores> MSS_DEF_Stores { get; set; }
        public DbSet<MSS_DEF_Orders> MSS_DEF_Orders { get; set; }
        public DbSet<MSS_DEF_P_Prices> MSS_DEF_P_Prices { get; set; }
        public DbSet<MSS_DEF_Permissions> MSS_DEF_Permissions { get; set; }
        public DbSet<MSS_DEF_Prices> MSS_DEF_Prices { get; set; }
        public DbSet<MSS_DEF_SMS> MSS_DEF_SMS { get; set; }
        public DbSet<MSS_DEF_Transactions> MSS_DEF_Transactions { get; set; }
        public DbSet<MSS_DEF_Vouchers> MSS_DEF_Vouchers { get; set; }
        public DbSet<MSS_FAV_FavAccounts> MSS_FAV_FavAccounts { get; set; }
        public DbSet<MSS_FIN_Avg> MSS_FIN_Avg { get; set; }
        public DbSet<MSS_INF_Action_Types> MSS_INF_Action_Types { get; set; }
        public DbSet<MSS_INF_Notifications> MSS_INF_Notifications { get; set; }
        public DbSet<MSS_INF_RegisterationFile> MSS_INF_RegisterationFile { get; set; }
        public DbSet<MSS_N_DEF_Employees> MSS_N_DEF_Employees { get; set; }
        public DbSet<MSS_TRS_Companies> MSS_TRS_Companies { get; set; }
        public DbSet<MSS_TRS_Individuals> MSS_TRS_Individuals { get; set; }


        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
