using AutoMapper;
using FatihBank.Data;
using FatihBank.DTOs;
using FatihBank.Models;
using Microsoft.EntityFrameworkCore;

namespace FatihBank.Repositories
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public EmployeesRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Employees>> ListAll(int page, float pageSize)
        {

            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Employees.Count() / pageSize);

            var employees = await dataContext.MSS_DEF_Employees
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Employees>
            {
                List = employees,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Employees> Add(EmployeesDto employeesDto)
        {
            var result = _mapper.Map<EmployeesDto, MSS_DEF_Employees>(employeesDto);
            await dataContext.MSS_DEF_Employees.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, EmployeesDto employeesDto)
        {
            var result = await dataContext.MSS_DEF_Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(employeesDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Employees.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
