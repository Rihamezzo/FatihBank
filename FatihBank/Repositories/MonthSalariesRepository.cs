using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class MonthSalariesRepository : IMonthSalariesRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public MonthSalariesRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_ATT_Month_Salaries>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_ATT_Month_Salaries.Count() / pageSize);

            var list = await dataContext.MSS_ATT_Month_Salaries.Include(x => x.employee)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_ATT_Month_Salaries>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_ATT_Month_Salaries> Add(MonthSalariesDto monthSalariesDto)
        {
            var result = _mapper.Map<MonthSalariesDto, MSS_ATT_Month_Salaries>(monthSalariesDto);
            await dataContext.MSS_ATT_Month_Salaries.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, MonthSalariesDto monthSalariesDto)
        {
            var result = await dataContext.MSS_ATT_Month_Salaries.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(monthSalariesDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_ATT_Month_Salaries.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_ATT_Month_Salaries.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
