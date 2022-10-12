using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class CurrenciesRepository : ICurrenciesRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public CurrenciesRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Currencies>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Currencies.Count() / pageSize);

            var currencies = await dataContext.MSS_DEF_Currencies
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Currencies>
            {
                List = currencies,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Currencies> Add(CurrenciesDto currenciesDto)
        {
            var result = _mapper.Map<CurrenciesDto, MSS_DEF_Currencies>(currenciesDto);
            await dataContext.MSS_DEF_Currencies.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, CurrenciesDto currenciesDto)
        {
            var result = await dataContext.MSS_DEF_Currencies.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(currenciesDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Currencies.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Currencies.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
