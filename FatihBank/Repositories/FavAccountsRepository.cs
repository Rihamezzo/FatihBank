
using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class FavAccountsRepository : IFavAccountsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public FavAccountsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_FAV_FavAccounts>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_FAV_FavAccounts.Count() / pageSize);

            var list = await dataContext.MSS_FAV_FavAccounts.Include(x => x.account)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_FAV_FavAccounts>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_FAV_FavAccounts> Add(FavAccountsDto favAccountsDto)
        {
            var result = _mapper.Map<FavAccountsDto, MSS_FAV_FavAccounts>(favAccountsDto);
            await dataContext.MSS_FAV_FavAccounts.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, FavAccountsDto favAccountsDto)
        {
            var result = await dataContext.MSS_FAV_FavAccounts.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(favAccountsDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_FAV_FavAccounts.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_FAV_FavAccounts.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
