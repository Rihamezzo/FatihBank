using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class AvgRepository : IAvgRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public AvgRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_FIN_Avg>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_FIN_Avg.Count() / pageSize);

            var list = await dataContext.MSS_FIN_Avg.Include(x => x.parent).Include(x => x.mainAvg)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_FIN_Avg>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_FIN_Avg> Add(AvgDto avgDto)
        {
            var result = _mapper.Map<AvgDto, MSS_FIN_Avg>(avgDto);
            await dataContext.MSS_FIN_Avg.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, AvgDto avgDto)
        {
            var result = await dataContext.MSS_FIN_Avg.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(avgDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_FIN_Avg.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_FIN_Avg.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
