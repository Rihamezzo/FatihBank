using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class PricesRepository : IPricesRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public PricesRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Prices>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Prices.Count() / pageSize);

            var list = await dataContext.MSS_DEF_Prices.Include(x => x.currency1).Include(x => x.currency2)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Prices>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Prices> Add(PricesDto pricesDto)
        {
            var result = _mapper.Map<PricesDto, MSS_DEF_Prices>(pricesDto);
            await dataContext.MSS_DEF_Prices.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, PricesDto pricesDto)
        {
            var result = await dataContext.MSS_DEF_Prices.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(pricesDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Prices.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Prices.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}