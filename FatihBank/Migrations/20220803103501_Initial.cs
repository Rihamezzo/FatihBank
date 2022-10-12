using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FatihBank.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MSS_ATT_ExcusesTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_ATT_ExcusesTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSS_ATT_VacationsTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_ATT_VacationsTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entry_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shortcut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isMain = table.Column<int>(type: "int", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entery_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<long>(type: "bigint", nullable: true),
                    sms = table.Column<int>(type: "int", nullable: false),
                    mobile = table.Column<long>(type: "bigint", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ident = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: true),
                    entery_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    special = table.Column<int>(type: "int", nullable: true),
                    employee = table.Column<int>(type: "int", nullable: false),
                    shipping = table.Column<int>(type: "int", nullable: false),
                    personal_photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_private = table.Column<int>(type: "int", nullable: true),
                    suspended = table.Column<int>(type: "int", nullable: false),
                    canOverLimit = table.Column<int>(type: "int", nullable: true),
                    notificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    limit = table.Column<double>(type: "float", nullable: true),
                    isPublic = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    mobile = table.Column<long>(type: "bigint", nullable: true),
                    phone = table.Column<long>(type: "bigint", nullable: true),
                    passport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idphoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Journals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<int>(type: "int", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total_amount = table.Column<double>(type: "float", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Journals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Modules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    group = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    day_of_holiday = table.Column<int>(type: "int", nullable: false),
                    work_start_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    work_leave_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    amount_of_accepted_late = table.Column<int>(type: "int", nullable: false),
                    discount_for_late_pre_hour = table.Column<double>(type: "float", nullable: false),
                    reward_for_additional_work_per_hour = table.Column<double>(type: "float", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entry_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Schedule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false),
                    loginName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    groupId = table.Column<int>(type: "int", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_online = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSS_INF_Action_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_INF_Action_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country_id = table.Column<int>(type: "int", nullable: false),
                    countryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Stores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Stores_MSS_DEF_Countries_countryId",
                        column: x => x.countryId,
                        principalTable: "MSS_DEF_Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_AVGs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    currency_id = table.Column<int>(type: "int", nullable: false),
                    currencyId = table.Column<int>(type: "int", nullable: true),
                    amount1 = table.Column<double>(type: "float", nullable: false),
                    amount2 = table.Column<double>(type: "float", nullable: false),
                    avg = table.Column<double>(type: "float", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_AVGs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_DEF_AVGs_MSS_DEF_Currencies_currencyId",
                        column: x => x.currencyId,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Cashiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    currency_id = table.Column<int>(type: "int", nullable: false),
                    currencyId = table.Column<int>(type: "int", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    amount = table.Column<double>(type: "float", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entery_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Cashiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Cashiers_MSS_DEF_Currencies_currencyId",
                        column: x => x.currencyId,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Exchange_Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    currency_id = table.Column<int>(type: "int", nullable: false),
                    currencyId = table.Column<int>(type: "int", nullable: true),
                    start_amount = table.Column<double>(type: "float", nullable: false),
                    price = table.Column<double>(type: "float", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entery_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    currency2_id = table.Column<int>(type: "int", nullable: true),
                    currency2Id = table.Column<int>(type: "int", nullable: true),
                    parent_id = table.Column<int>(type: "int", nullable: true),
                    parentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Exchange_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Exchange_Accounts_MSS_DEF_Currencies_currency2Id",
                        column: x => x.currency2Id,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Exchange_Accounts_MSS_DEF_Currencies_currencyId",
                        column: x => x.currencyId,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Exchange_Accounts_MSS_DEF_Exchange_Accounts_parentId",
                        column: x => x.parentId,
                        principalTable: "MSS_DEF_Exchange_Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Prices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    currency1_id = table.Column<int>(type: "int", nullable: false),
                    currency1Id = table.Column<int>(type: "int", nullable: true),
                    currency2_id = table.Column<int>(type: "int", nullable: false),
                    currency2Id = table.Column<int>(type: "int", nullable: true),
                    s_price = table.Column<double>(type: "float", nullable: false),
                    b_price = table.Column<double>(type: "float", nullable: false),
                    commission = table.Column<double>(type: "float", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    update_by = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Prices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Prices_MSS_DEF_Currencies_currency1Id",
                        column: x => x.currency1Id,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Prices_MSS_DEF_Currencies_currency2Id",
                        column: x => x.currency2Id,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    oldId = table.Column<int>(type: "int", nullable: true),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    customerId = table.Column<int>(type: "int", nullable: true),
                    currency_id = table.Column<int>(type: "int", nullable: false),
                    currencyId = table.Column<int>(type: "int", nullable: true),
                    start_amount = table.Column<double>(type: "float", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entery_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    current_amount = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<int>(type: "int", nullable: true),
                    commissioned = table.Column<int>(type: "int", nullable: true),
                    profit_id = table.Column<int>(type: "int", nullable: true),
                    IBAN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Accounts_MSS_DEF_Currencies_currencyId",
                        column: x => x.currencyId,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Accounts_MSS_DEF_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "MSS_DEF_Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_N_DEF_Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    father_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mother_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birth_place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    national_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_id = table.Column<int>(type: "int", nullable: true),
                    customerId = table.Column<int>(type: "int", nullable: true),
                    salary_account = table.Column<int>(type: "int", nullable: true),
                    personal_photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    finger_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    job_position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    identity_photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salary_per_hour = table.Column<double>(type: "float", nullable: false),
                    attendance_schedule = table.Column<int>(type: "int", nullable: false),
                    is_resigned = table.Column<int>(type: "int", nullable: true),
                    birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    enroll_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_number = table.Column<long>(type: "bigint", nullable: false),
                    mobile_number = table.Column<long>(type: "bigint", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entry_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_N_DEF_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_N_DEF_Employees_MSS_DEF_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "MSS_DEF_Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_ATT_Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: true),
                    date = table.Column<DateTime>(type: "Date", nullable: false),
                    discount = table.Column<double>(type: "float", nullable: false),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    on_salary = table.Column<bool>(type: "bit", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entry_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_ATT_Discounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_ATT_Discounts_MSS_DEF_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "MSS_DEF_Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_ATT_Excuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: true),
                    request_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    excuses_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    excuses_type = table.Column<int>(type: "int", nullable: false),
                    excusesTypeId = table.Column<int>(type: "int", nullable: true),
                    leave_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    return_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    actual_return_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    processed_by = table.Column<int>(type: "int", nullable: false),
                    process_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_ATT_Excuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_ATT_Excuses_MSS_ATT_ExcusesTypes_excusesTypeId",
                        column: x => x.excusesTypeId,
                        principalTable: "MSS_ATT_ExcusesTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_ATT_Excuses_MSS_DEF_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "MSS_DEF_Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_ATT_Month_Salaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: true),
                    month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    attended_days = table.Column<int>(type: "int", nullable: false),
                    from_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    to_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    net_salary = table.Column<double>(type: "float", nullable: false),
                    basic_salary = table.Column<double>(type: "float", nullable: false),
                    discount_amount = table.Column<double>(type: "float", nullable: false),
                    added_amount = table.Column<double>(type: "float", nullable: false),
                    is_paid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_ATT_Month_Salaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_ATT_Month_Salaries_MSS_DEF_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "MSS_DEF_Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_ATT_Rewards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: true),
                    date = table.Column<DateTime>(type: "Date", nullable: false),
                    reward = table.Column<double>(type: "float", nullable: false),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    on_salary = table.Column<bool>(type: "bit", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entry_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_ATT_Rewards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_ATT_Rewards_MSS_DEF_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "MSS_DEF_Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_ATT_Vacations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: true),
                    vacation_type = table.Column<int>(type: "int", nullable: false),
                    vacationTypeId = table.Column<int>(type: "int", nullable: true),
                    vacationsTypeId = table.Column<int>(type: "int", nullable: false),
                    no_of_days = table.Column<int>(type: "int", nullable: false),
                    request_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    processed_by = table.Column<int>(type: "int", nullable: false),
                    process_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_ATT_Vacations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_ATT_Vacations_MSS_ATT_VacationsTypes_vacationsTypeId",
                        column: x => x.vacationsTypeId,
                        principalTable: "MSS_ATT_VacationsTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MSS_ATT_Vacations_MSS_DEF_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "MSS_DEF_Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_ATT_Daily_Attendance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "Date", nullable: false),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: true),
                    in_come_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    leave_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    is_absent = table.Column<int>(type: "int", nullable: false),
                    is_excused = table.Column<int>(type: "int", nullable: false),
                    schedule_id = table.Column<int>(type: "int", nullable: false),
                    scheduleId = table.Column<int>(type: "int", nullable: true),
                    late_minutes = table.Column<int>(type: "int", nullable: false),
                    additional_minutes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_ATT_Daily_Attendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_ATT_Daily_Attendance_MSS_DEF_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "MSS_DEF_Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_ATT_Daily_Attendance_MSS_DEF_Schedule_scheduleId",
                        column: x => x.scheduleId,
                        principalTable: "MSS_DEF_Schedule",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_ATT_Month_Info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: true),
                    schedule_id = table.Column<int>(type: "int", nullable: false),
                    scheduleId = table.Column<int>(type: "int", nullable: true),
                    due_days = table.Column<double>(type: "float", nullable: false),
                    due_hours = table.Column<double>(type: "float", nullable: false),
                    absent_days = table.Column<double>(type: "float", nullable: false),
                    late_hours = table.Column<double>(type: "float", nullable: false),
                    excused_days = table.Column<double>(type: "float", nullable: false),
                    add_hours = table.Column<double>(type: "float", nullable: true),
                    real_days = table.Column<double>(type: "float", nullable: false),
                    real_hours = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_ATT_Month_Info", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_ATT_Month_Info_MSS_DEF_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "MSS_DEF_Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_ATT_Month_Info_MSS_DEF_Schedule_scheduleId",
                        column: x => x.scheduleId,
                        principalTable: "MSS_DEF_Schedule",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_CHT_ChatList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    s_1 = table.Column<int>(type: "int", nullable: false),
                    user1Id = table.Column<int>(type: "int", nullable: true),
                    s_2 = table.Column<int>(type: "int", nullable: false),
                    user2Id = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_CHT_ChatList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_CHT_ChatList_MSS_DEF_Users_user1Id",
                        column: x => x.user1Id,
                        principalTable: "MSS_DEF_Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_CHT_ChatList_MSS_DEF_Users_user2Id",
                        column: x => x.user2Id,
                        principalTable: "MSS_DEF_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_P_Prices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    currency_id = table.Column<int>(type: "int", nullable: false),
                    currencyId = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    divide = table.Column<int>(type: "int", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_P_Prices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_DEF_P_Prices_MSS_DEF_Currencies_currencyId",
                        column: x => x.currencyId,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_P_Prices_MSS_DEF_Users_userId",
                        column: x => x.userId,
                        principalTable: "MSS_DEF_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    module_id = table.Column<int>(type: "int", nullable: false),
                    module1Id = table.Column<int>(type: "int", nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: true),
                    type = table.Column<int>(type: "int", nullable: false),
                    module = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Permissions_MSS_DEF_Modules_module1Id",
                        column: x => x.module1Id,
                        principalTable: "MSS_DEF_Modules",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Permissions_MSS_DEF_Users_userId",
                        column: x => x.userId,
                        principalTable: "MSS_DEF_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_SMS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sent_by = table.Column<int>(type: "int", nullable: false),
                    sent_by_userId = table.Column<int>(type: "int", nullable: true),
                    sent_to_customer = table.Column<int>(type: "int", nullable: false),
                    sent_to_CustomerId = table.Column<int>(type: "int", nullable: true),
                    phone_number = table.Column<long>(type: "bigint", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_SMS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_DEF_SMS_MSS_DEF_Customers_sent_to_CustomerId",
                        column: x => x.sent_to_CustomerId,
                        principalTable: "MSS_DEF_Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_SMS_MSS_DEF_Users_sent_by_userId",
                        column: x => x.sent_by_userId,
                        principalTable: "MSS_DEF_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_INF_Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    from_id = table.Column<int>(type: "int", nullable: false),
                    fromId = table.Column<int>(type: "int", nullable: true),
                    to_id = table.Column<int>(type: "int", nullable: false),
                    toId = table.Column<int>(type: "int", nullable: true),
                    object_id = table.Column<int>(type: "int", nullable: false),
                    action_id = table.Column<int>(type: "int", nullable: false),
                    obj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_read = table.Column<bool>(type: "bit", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_INF_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_INF_Notifications_MSS_DEF_Users_fromId",
                        column: x => x.fromId,
                        principalTable: "MSS_DEF_Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_INF_Notifications_MSS_DEF_Users_toId",
                        column: x => x.toId,
                        principalTable: "MSS_DEF_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_CAS_Operations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cashier_id = table.Column<int>(type: "int", nullable: false),
                    cashierId = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<double>(type: "float", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entry_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_CAS_Operations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_CAS_Operations_MSS_DEF_Cashiers_cashierId",
                        column: x => x.cashierId,
                        principalTable: "MSS_DEF_Cashiers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_AVG_MainAvg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    currency_1 = table.Column<int>(type: "int", nullable: false),
                    currency1Id = table.Column<int>(type: "int", nullable: true),
                    currency1_amount = table.Column<double>(type: "float", nullable: false),
                    currency_2 = table.Column<int>(type: "int", nullable: false),
                    currency2Id = table.Column<int>(type: "int", nullable: true),
                    currency2_amount = table.Column<double>(type: "float", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    exchange_account = table.Column<int>(type: "int", nullable: true),
                    exchange_accountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_AVG_MainAvg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_AVG_MainAvg_MSS_DEF_Currencies_currency1Id",
                        column: x => x.currency1Id,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_AVG_MainAvg_MSS_DEF_Currencies_currency2Id",
                        column: x => x.currency2Id,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_AVG_MainAvg_MSS_DEF_Exchange_Accounts_exchange_accountId",
                        column: x => x.exchange_accountId,
                        principalTable: "MSS_DEF_Exchange_Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_ACC_Checks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    accountId = table.Column<int>(type: "int", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    amount = table.Column<double>(type: "float", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_ACC_Checks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_ACC_Checks_MSS_DEF_Accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_CUS_Add_To_Monthly_List",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    accountId = table.Column<int>(type: "int", nullable: true),
                    currency_id = table.Column<int>(type: "int", nullable: false),
                    currencyId = table.Column<int>(type: "int", nullable: true),
                    percent = table.Column<double>(type: "float", nullable: false),
                    profit_id = table.Column<int>(type: "int", nullable: false),
                    profitAccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_CUS_Add_To_Monthly_List", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_CUS_Add_To_Monthly_List_MSS_DEF_Accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_CUS_Add_To_Monthly_List_MSS_DEF_Accounts_profitAccountId",
                        column: x => x.profitAccountId,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_CUS_Add_To_Monthly_List_MSS_DEF_Currencies_currencyId",
                        column: x => x.currencyId,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Commission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    accountId = table.Column<int>(type: "int", nullable: true),
                    profit_id = table.Column<int>(type: "int", nullable: false),
                    profitAccountId = table.Column<int>(type: "int", nullable: true),
                    from_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    to_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entry_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total_amount = table.Column<double>(type: "float", nullable: true),
                    total_profit = table.Column<double>(type: "float", nullable: false),
                    total_percent = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Commission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Commission_MSS_DEF_Accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Commission_MSS_DEF_Accounts_profitAccountId",
                        column: x => x.profitAccountId,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_MCD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account1_id = table.Column<int>(type: "int", nullable: false),
                    account1Id = table.Column<int>(type: "int", nullable: true),
                    account2_id = table.Column<int>(type: "int", nullable: false),
                    account2Id = table.Column<int>(type: "int", nullable: true),
                    profit_id = table.Column<int>(type: "int", nullable: true),
                    profitAccountId = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<double>(type: "float", nullable: false),
                    commission = table.Column<double>(type: "float", nullable: true),
                    type = table.Column<int>(type: "int", nullable: true),
                    notes1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notes2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entry_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    notes_for_profit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_of_operation = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_MCD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_DEF_MCD_MSS_DEF_Accounts_account1Id",
                        column: x => x.account1Id,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_MCD_MSS_DEF_Accounts_account2Id",
                        column: x => x.account2Id,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_MCD_MSS_DEF_Accounts_profitAccountId",
                        column: x => x.profitAccountId,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    accountId = table.Column<int>(type: "int", nullable: true),
                    store_id = table.Column<int>(type: "int", nullable: false),
                    storeId = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<int>(type: "int", nullable: false),
                    method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: true),
                    entered_by = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Orders_MSS_DEF_Accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Orders_MSS_DEF_Stores_storeId",
                        column: x => x.storeId,
                        principalTable: "MSS_DEF_Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sub_id = table.Column<int>(type: "int", nullable: true),
                    type = table.Column<int>(type: "int", nullable: false),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    accountId = table.Column<int>(type: "int", nullable: true),
                    cashier_id = table.Column<int>(type: "int", nullable: false),
                    cashierId = table.Column<int>(type: "int", nullable: true),
                    current_total = table.Column<double>(type: "float", nullable: false),
                    current_total2 = table.Column<double>(type: "float", nullable: false),
                    currency_id = table.Column<int>(type: "int", nullable: false),
                    currencyId = table.Column<int>(type: "int", nullable: true),
                    exchange_account = table.Column<int>(type: "int", nullable: false),
                    exchangeId = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<double>(type: "float", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    extra_price = table.Column<double>(type: "float", nullable: true),
                    country_id = table.Column<int>(type: "int", nullable: false),
                    countryId = table.Column<int>(type: "int", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entry_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total = table.Column<double>(type: "float", nullable: false),
                    currency_2 = table.Column<int>(type: "int", nullable: false),
                    currency2Id = table.Column<int>(type: "int", nullable: true),
                    exchange_account1 = table.Column<double>(type: "float", nullable: true),
                    exchange_account2 = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Transactions_MSS_DEF_Accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Transactions_MSS_DEF_Cashiers_cashierId",
                        column: x => x.cashierId,
                        principalTable: "MSS_DEF_Cashiers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Transactions_MSS_DEF_Countries_countryId",
                        column: x => x.countryId,
                        principalTable: "MSS_DEF_Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Transactions_MSS_DEF_Currencies_currency2Id",
                        column: x => x.currency2Id,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Transactions_MSS_DEF_Currencies_currencyId",
                        column: x => x.currencyId,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Transactions_MSS_DEF_Exchange_Accounts_exchangeId",
                        column: x => x.exchangeId,
                        principalTable: "MSS_DEF_Exchange_Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_FAV_FavAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    accountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_FAV_FavAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_FAV_FavAccounts_MSS_DEF_Accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_INF_RegisterationFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: true),
                    entry_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    operation_type = table.Column<int>(type: "int", nullable: false),
                    operation_id = table.Column<int>(type: "int", nullable: false),
                    action_type = table.Column<int>(type: "int", nullable: false),
                    Action_typeId = table.Column<int>(type: "int", nullable: true),
                    account_id = table.Column<int>(type: "int", nullable: true),
                    accountId = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<double>(type: "float", nullable: true),
                    subtype = table.Column<int>(type: "int", nullable: true),
                    cashier_id = table.Column<int>(type: "int", nullable: true),
                    cashierId = table.Column<int>(type: "int", nullable: true),
                    currency_id = table.Column<int>(type: "int", nullable: true),
                    currencyId = table.Column<int>(type: "int", nullable: true),
                    exchange_id = table.Column<int>(type: "int", nullable: true),
                    exchangeId = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    computer_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_INF_RegisterationFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_INF_RegisterationFile_MSS_DEF_Accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_INF_RegisterationFile_MSS_DEF_Cashiers_cashierId",
                        column: x => x.cashierId,
                        principalTable: "MSS_DEF_Cashiers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_INF_RegisterationFile_MSS_DEF_Currencies_currencyId",
                        column: x => x.currencyId,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_INF_RegisterationFile_MSS_DEF_Exchange_Accounts_exchangeId",
                        column: x => x.exchangeId,
                        principalTable: "MSS_DEF_Exchange_Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_INF_RegisterationFile_MSS_DEF_Users_userId",
                        column: x => x.userId,
                        principalTable: "MSS_DEF_Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_INF_RegisterationFile_MSS_INF_Action_Types_Action_typeId",
                        column: x => x.Action_typeId,
                        principalTable: "MSS_INF_Action_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_JOU_Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    journalId = table.Column<int>(type: "int", nullable: true),
                    accountId = table.Column<int>(type: "int", nullable: true),
                    customerId = table.Column<int>(type: "int", nullable: true),
                    currencyAmount = table.Column<double>(type: "float", nullable: true),
                    currencyId = table.Column<int>(type: "int", nullable: true),
                    inAmount = table.Column<double>(type: "float", nullable: true),
                    outAmount = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_JOU_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_JOU_Details_MSS_DEF_Accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_JOU_Details_MSS_DEF_Currencies_currencyId",
                        column: x => x.currencyId,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_JOU_Details_MSS_DEF_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "MSS_DEF_Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_JOU_Details_MSS_DEF_Journals_journalId",
                        column: x => x.journalId,
                        principalTable: "MSS_DEF_Journals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_TRS_Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    accountId = table.Column<int>(type: "int", nullable: true),
                    deliever_from = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_delievered = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<double>(type: "float", nullable: false),
                    cashier_id = table.Column<int>(type: "int", nullable: false),
                    cashierId = table.Column<int>(type: "int", nullable: true),
                    order_by = table.Column<int>(type: "int", nullable: false),
                    delievered_by = table.Column<int>(type: "int", nullable: true),
                    order_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deliever_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_TRS_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_TRS_Companies_MSS_DEF_Accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_TRS_Companies_MSS_DEF_Cashiers_cashierId",
                        column: x => x.cashierId,
                        principalTable: "MSS_DEF_Cashiers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_TRS_Individuals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    accountId = table.Column<int>(type: "int", nullable: true),
                    deliever_to = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_delievered = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<double>(type: "float", nullable: false),
                    cashier_id = table.Column<int>(type: "int", nullable: false),
                    cashierId = table.Column<int>(type: "int", nullable: true),
                    order_by = table.Column<int>(type: "int", nullable: false),
                    delievered_by = table.Column<int>(type: "int", nullable: true),
                    order_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deliever_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_TRS_Individuals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_TRS_Individuals_MSS_DEF_Accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_TRS_Individuals_MSS_DEF_Cashiers_cashierId",
                        column: x => x.cashierId,
                        principalTable: "MSS_DEF_Cashiers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_FIN_Avg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    main_avg = table.Column<int>(type: "int", nullable: false),
                    mainAvgId = table.Column<int>(type: "int", nullable: true),
                    operation_id = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false),
                    currency1_amount = table.Column<double>(type: "float", nullable: false),
                    currency2_amount = table.Column<double>(type: "float", nullable: false),
                    parent_id = table.Column<int>(type: "int", nullable: false),
                    parentId = table.Column<int>(type: "int", nullable: true),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entry_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_FIN_Avg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_FIN_Avg_MSS_AVG_MainAvg_mainAvgId",
                        column: x => x.mainAvgId,
                        principalTable: "MSS_AVG_MainAvg",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_FIN_Avg_MSS_FIN_Avg_parentId",
                        column: x => x.parentId,
                        principalTable: "MSS_FIN_Avg",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MSS_DEF_Vouchers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    accountId = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<double>(type: "float", nullable: false),
                    total = table.Column<double>(type: "float", nullable: true),
                    cashier_id = table.Column<int>(type: "int", nullable: false),
                    cashierId = table.Column<int>(type: "int", nullable: true),
                    method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entered_by = table.Column<int>(type: "int", nullable: false),
                    entry_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    type = table.Column<int>(type: "int", nullable: false),
                    transaction_id = table.Column<int>(type: "int", nullable: true),
                    transactionId = table.Column<int>(type: "int", nullable: true),
                    account2_id = table.Column<int>(type: "int", nullable: true),
                    account2Id = table.Column<int>(type: "int", nullable: true),
                    current_total = table.Column<double>(type: "float", nullable: false),
                    current_total2 = table.Column<double>(type: "float", nullable: false),
                    currency1 = table.Column<int>(type: "int", nullable: true),
                    Currency1Id = table.Column<int>(type: "int", nullable: true),
                    currency2 = table.Column<int>(type: "int", nullable: true),
                    Currency2Id = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    type2 = table.Column<int>(type: "int", nullable: true),
                    num = table.Column<int>(type: "int", nullable: true),
                    total_cashier = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSS_DEF_Vouchers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Vouchers_MSS_DEF_Accounts_account2Id",
                        column: x => x.account2Id,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Vouchers_MSS_DEF_Accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "MSS_DEF_Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Vouchers_MSS_DEF_Cashiers_cashierId",
                        column: x => x.cashierId,
                        principalTable: "MSS_DEF_Cashiers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Vouchers_MSS_DEF_Currencies_Currency1Id",
                        column: x => x.Currency1Id,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Vouchers_MSS_DEF_Currencies_Currency2Id",
                        column: x => x.Currency2Id,
                        principalTable: "MSS_DEF_Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MSS_DEF_Vouchers_MSS_DEF_Transactions_transactionId",
                        column: x => x.transactionId,
                        principalTable: "MSS_DEF_Transactions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MSS_ACC_Checks_accountId",
                table: "MSS_ACC_Checks",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_ATT_Daily_Attendance_employeeId",
                table: "MSS_ATT_Daily_Attendance",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_ATT_Daily_Attendance_scheduleId",
                table: "MSS_ATT_Daily_Attendance",
                column: "scheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_ATT_Discounts_employeeId",
                table: "MSS_ATT_Discounts",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_ATT_Excuses_employeeId",
                table: "MSS_ATT_Excuses",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_ATT_Excuses_excusesTypeId",
                table: "MSS_ATT_Excuses",
                column: "excusesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_ATT_Month_Info_employeeId",
                table: "MSS_ATT_Month_Info",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_ATT_Month_Info_scheduleId",
                table: "MSS_ATT_Month_Info",
                column: "scheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_ATT_Month_Salaries_employeeId",
                table: "MSS_ATT_Month_Salaries",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_ATT_Rewards_employeeId",
                table: "MSS_ATT_Rewards",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_ATT_Vacations_employeeId",
                table: "MSS_ATT_Vacations",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_ATT_Vacations_vacationsTypeId",
                table: "MSS_ATT_Vacations",
                column: "vacationsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_AVG_MainAvg_currency1Id",
                table: "MSS_AVG_MainAvg",
                column: "currency1Id");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_AVG_MainAvg_currency2Id",
                table: "MSS_AVG_MainAvg",
                column: "currency2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_AVG_MainAvg_exchange_accountId",
                table: "MSS_AVG_MainAvg",
                column: "exchange_accountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_CAS_Operations_cashierId",
                table: "MSS_CAS_Operations",
                column: "cashierId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_CHT_ChatList_user1Id",
                table: "MSS_CHT_ChatList",
                column: "user1Id");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_CHT_ChatList_user2Id",
                table: "MSS_CHT_ChatList",
                column: "user2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_CUS_Add_To_Monthly_List_accountId",
                table: "MSS_CUS_Add_To_Monthly_List",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_CUS_Add_To_Monthly_List_currencyId",
                table: "MSS_CUS_Add_To_Monthly_List",
                column: "currencyId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_CUS_Add_To_Monthly_List_profitAccountId",
                table: "MSS_CUS_Add_To_Monthly_List",
                column: "profitAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Accounts_currencyId",
                table: "MSS_DEF_Accounts",
                column: "currencyId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Accounts_customerId",
                table: "MSS_DEF_Accounts",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_AVGs_currencyId",
                table: "MSS_DEF_AVGs",
                column: "currencyId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Cashiers_currencyId",
                table: "MSS_DEF_Cashiers",
                column: "currencyId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Commission_accountId",
                table: "MSS_DEF_Commission",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Commission_profitAccountId",
                table: "MSS_DEF_Commission",
                column: "profitAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Exchange_Accounts_currency2Id",
                table: "MSS_DEF_Exchange_Accounts",
                column: "currency2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Exchange_Accounts_currencyId",
                table: "MSS_DEF_Exchange_Accounts",
                column: "currencyId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Exchange_Accounts_parentId",
                table: "MSS_DEF_Exchange_Accounts",
                column: "parentId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_MCD_account1Id",
                table: "MSS_DEF_MCD",
                column: "account1Id");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_MCD_account2Id",
                table: "MSS_DEF_MCD",
                column: "account2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_MCD_profitAccountId",
                table: "MSS_DEF_MCD",
                column: "profitAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Orders_accountId",
                table: "MSS_DEF_Orders",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Orders_storeId",
                table: "MSS_DEF_Orders",
                column: "storeId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_P_Prices_currencyId",
                table: "MSS_DEF_P_Prices",
                column: "currencyId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_P_Prices_userId",
                table: "MSS_DEF_P_Prices",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Permissions_module1Id",
                table: "MSS_DEF_Permissions",
                column: "module1Id");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Permissions_userId",
                table: "MSS_DEF_Permissions",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Prices_currency1Id",
                table: "MSS_DEF_Prices",
                column: "currency1Id");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Prices_currency2Id",
                table: "MSS_DEF_Prices",
                column: "currency2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_SMS_sent_by_userId",
                table: "MSS_DEF_SMS",
                column: "sent_by_userId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_SMS_sent_to_CustomerId",
                table: "MSS_DEF_SMS",
                column: "sent_to_CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Stores_countryId",
                table: "MSS_DEF_Stores",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Transactions_accountId",
                table: "MSS_DEF_Transactions",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Transactions_cashierId",
                table: "MSS_DEF_Transactions",
                column: "cashierId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Transactions_countryId",
                table: "MSS_DEF_Transactions",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Transactions_currency2Id",
                table: "MSS_DEF_Transactions",
                column: "currency2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Transactions_currencyId",
                table: "MSS_DEF_Transactions",
                column: "currencyId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Transactions_exchangeId",
                table: "MSS_DEF_Transactions",
                column: "exchangeId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Vouchers_account2Id",
                table: "MSS_DEF_Vouchers",
                column: "account2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Vouchers_accountId",
                table: "MSS_DEF_Vouchers",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Vouchers_cashierId",
                table: "MSS_DEF_Vouchers",
                column: "cashierId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Vouchers_Currency1Id",
                table: "MSS_DEF_Vouchers",
                column: "Currency1Id");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Vouchers_Currency2Id",
                table: "MSS_DEF_Vouchers",
                column: "Currency2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_DEF_Vouchers_transactionId",
                table: "MSS_DEF_Vouchers",
                column: "transactionId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_FAV_FavAccounts_accountId",
                table: "MSS_FAV_FavAccounts",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_FIN_Avg_mainAvgId",
                table: "MSS_FIN_Avg",
                column: "mainAvgId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_FIN_Avg_parentId",
                table: "MSS_FIN_Avg",
                column: "parentId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_INF_Notifications_fromId",
                table: "MSS_INF_Notifications",
                column: "fromId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_INF_Notifications_toId",
                table: "MSS_INF_Notifications",
                column: "toId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_INF_RegisterationFile_accountId",
                table: "MSS_INF_RegisterationFile",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_INF_RegisterationFile_Action_typeId",
                table: "MSS_INF_RegisterationFile",
                column: "Action_typeId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_INF_RegisterationFile_cashierId",
                table: "MSS_INF_RegisterationFile",
                column: "cashierId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_INF_RegisterationFile_currencyId",
                table: "MSS_INF_RegisterationFile",
                column: "currencyId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_INF_RegisterationFile_exchangeId",
                table: "MSS_INF_RegisterationFile",
                column: "exchangeId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_INF_RegisterationFile_userId",
                table: "MSS_INF_RegisterationFile",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_JOU_Details_accountId",
                table: "MSS_JOU_Details",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_JOU_Details_currencyId",
                table: "MSS_JOU_Details",
                column: "currencyId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_JOU_Details_customerId",
                table: "MSS_JOU_Details",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_JOU_Details_journalId",
                table: "MSS_JOU_Details",
                column: "journalId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_N_DEF_Employees_customerId",
                table: "MSS_N_DEF_Employees",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_TRS_Companies_accountId",
                table: "MSS_TRS_Companies",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_TRS_Companies_cashierId",
                table: "MSS_TRS_Companies",
                column: "cashierId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_TRS_Individuals_accountId",
                table: "MSS_TRS_Individuals",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_MSS_TRS_Individuals_cashierId",
                table: "MSS_TRS_Individuals",
                column: "cashierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MSS_ACC_Checks");

            migrationBuilder.DropTable(
                name: "MSS_ATT_Daily_Attendance");

            migrationBuilder.DropTable(
                name: "MSS_ATT_Discounts");

            migrationBuilder.DropTable(
                name: "MSS_ATT_Excuses");

            migrationBuilder.DropTable(
                name: "MSS_ATT_Month_Info");

            migrationBuilder.DropTable(
                name: "MSS_ATT_Month_Salaries");

            migrationBuilder.DropTable(
                name: "MSS_ATT_Rewards");

            migrationBuilder.DropTable(
                name: "MSS_ATT_Vacations");

            migrationBuilder.DropTable(
                name: "MSS_CAS_Operations");

            migrationBuilder.DropTable(
                name: "MSS_CHT_ChatList");

            migrationBuilder.DropTable(
                name: "MSS_CUS_Add_To_Monthly_List");

            migrationBuilder.DropTable(
                name: "MSS_DEF_AVGs");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Commission");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Groups");

            migrationBuilder.DropTable(
                name: "MSS_DEF_MCD");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Orders");

            migrationBuilder.DropTable(
                name: "MSS_DEF_P_Prices");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Permissions");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Prices");

            migrationBuilder.DropTable(
                name: "MSS_DEF_SMS");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Vouchers");

            migrationBuilder.DropTable(
                name: "MSS_FAV_FavAccounts");

            migrationBuilder.DropTable(
                name: "MSS_FIN_Avg");

            migrationBuilder.DropTable(
                name: "MSS_INF_Notifications");

            migrationBuilder.DropTable(
                name: "MSS_INF_RegisterationFile");

            migrationBuilder.DropTable(
                name: "MSS_JOU_Details");

            migrationBuilder.DropTable(
                name: "MSS_N_DEF_Employees");

            migrationBuilder.DropTable(
                name: "MSS_TRS_Companies");

            migrationBuilder.DropTable(
                name: "MSS_TRS_Individuals");

            migrationBuilder.DropTable(
                name: "MSS_ATT_ExcusesTypes");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Schedule");

            migrationBuilder.DropTable(
                name: "MSS_ATT_VacationsTypes");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Employees");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Stores");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Modules");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Transactions");

            migrationBuilder.DropTable(
                name: "MSS_AVG_MainAvg");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Users");

            migrationBuilder.DropTable(
                name: "MSS_INF_Action_Types");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Journals");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Accounts");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Cashiers");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Countries");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Exchange_Accounts");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Customers");

            migrationBuilder.DropTable(
                name: "MSS_DEF_Currencies");
        }
    }
}
