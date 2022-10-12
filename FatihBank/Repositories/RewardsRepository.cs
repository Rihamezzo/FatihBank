using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class RewardsRepository : IRewardsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public RewardsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_ATT_Rewards>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_ATT_Rewards.Count() / pageSize);

            var list = await dataContext.MSS_ATT_Rewards.Include(x => x.employee)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_ATT_Rewards>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_ATT_Rewards> Add(RewardsDto rewardsDto)
        {
            var result = _mapper.Map<RewardsDto, MSS_ATT_Rewards>(rewardsDto);
            await dataContext.MSS_ATT_Rewards.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, RewardsDto rewardsDto)
        {
            var result = await dataContext.MSS_ATT_Rewards.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(rewardsDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_ATT_Rewards.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_ATT_Rewards.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}