using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class AccountsRepository : IAccountsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public AccountsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Accounts>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Accounts.Count() / pageSize);

            var accounts = await dataContext.MSS_DEF_Accounts.Include(x => x.customer).Include(x => x.currency).Include(x => x.checks)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Accounts>
            {
                List = accounts,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Accounts> Add(AccountsDto accountsDto)
        {
            var result = _mapper.Map<AccountsDto, MSS_DEF_Accounts>(accountsDto);
            await dataContext.MSS_DEF_Accounts.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, AccountsDto accountsDto)
        {
            var result = await dataContext.MSS_DEF_Accounts.FirstOrDefaultAsync(e => e.Id == accountsDto.Id);
            if (result != null)
            {
                _mapper.Map(accountsDto, result);
                await dataContext.SaveChanges();
            }

        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Accounts.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Accounts.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
