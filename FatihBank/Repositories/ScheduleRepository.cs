using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public ScheduleRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Schedule>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Schedule.Count() / pageSize);

            var list = await dataContext.MSS_DEF_Schedule.Include(x => x.month_Infos)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Schedule>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Schedule> Add(ScheduleDto scheduleDto)
        {
            var result = _mapper.Map<ScheduleDto, MSS_DEF_Schedule>(scheduleDto);
            await dataContext.MSS_DEF_Schedule.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, ScheduleDto scheduleDto)
        {
            var result = await dataContext.MSS_DEF_Schedule.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(scheduleDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Schedule.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Schedule.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}