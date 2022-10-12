using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class MonthInfoRepository : IMonthInfoRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public MonthInfoRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_ATT_Month_Info>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_ATT_Month_Info.Count() / pageSize);

            var list = await dataContext.MSS_ATT_Month_Info.Include(x => x.employee).Include(x => x.schedule)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_ATT_Month_Info>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_ATT_Month_Info> Add(MonthInfoDto monthInfoDto)
        {
            var result = _mapper.Map<MonthInfoDto, MSS_ATT_Month_Info>(monthInfoDto);
            await dataContext.MSS_ATT_Month_Info.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, MonthInfoDto monthInfoDto)
        {
            var result = await dataContext.MSS_ATT_Month_Info.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(monthInfoDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_ATT_Month_Info.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_ATT_Month_Info.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}