using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class DEF_EmployeesRepository : IDEF_EmployeesRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public DEF_EmployeesRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_N_DEF_Employees>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_N_DEF_Employees.Count() / pageSize);

            var list = await dataContext.MSS_N_DEF_Employees.Include(x => x.customer)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_N_DEF_Employees>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_N_DEF_Employees> Add(DEF_EmployeesDto dEF_EmployeesDto)
        {
            var result = _mapper.Map<DEF_EmployeesDto, MSS_N_DEF_Employees>(dEF_EmployeesDto);
            await dataContext.MSS_N_DEF_Employees.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, DEF_EmployeesDto dEF_EmployeesDto)
        {
            var result = await dataContext.MSS_N_DEF_Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(dEF_EmployeesDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_N_DEF_Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_N_DEF_Employees.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
