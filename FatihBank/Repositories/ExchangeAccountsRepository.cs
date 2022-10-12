
using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class ExchangeAccountsRepository : IExchangeAccountsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public ExchangeAccountsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Exchange_Accounts>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Exchange_Accounts.Count() / pageSize);

            var list = await dataContext.MSS_DEF_Exchange_Accounts.Include(x => x.currency).Include(x => x.currency2).Include(x => x.parent)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Exchange_Accounts>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Exchange_Accounts> Add(ExchangeAccountsDto exchangeAccountsDto)
        {
            var result = _mapper.Map<ExchangeAccountsDto, MSS_DEF_Exchange_Accounts>(exchangeAccountsDto);
            await dataContext.MSS_DEF_Exchange_Accounts.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, ExchangeAccountsDto exchangeAccountsDto)
        {
            var result = await dataContext.MSS_DEF_Exchange_Accounts.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(exchangeAccountsDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Exchange_Accounts.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Exchange_Accounts.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}