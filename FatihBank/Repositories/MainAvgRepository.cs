
using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class MainAvgRepository : IMainAvgRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public MainAvgRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_AVG_MainAvg>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_AVG_MainAvg.Count() / pageSize);

            var list = await dataContext.MSS_AVG_MainAvg.Include(x => x.currency1).Include(x => x.currency2).Include(x => x.exchangeAccount)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_AVG_MainAvg>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_AVG_MainAvg> Add(MainAvgDto mainAvgDto)
        {
            var result = _mapper.Map<MainAvgDto, MSS_AVG_MainAvg>(mainAvgDto);
            await dataContext.MSS_AVG_MainAvg.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, MainAvgDto mainAvgDto)
        {
            var result = await dataContext.MSS_AVG_MainAvg.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(mainAvgDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_AVG_MainAvg.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_AVG_MainAvg.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}