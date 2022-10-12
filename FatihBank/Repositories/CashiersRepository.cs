using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class CashiersRepository : ICashiersRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public CashiersRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Cashiers>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Cashiers.Count() / pageSize);

            var currencies = await dataContext.MSS_DEF_Cashiers.Include(x => x.currency).Include(x => x.operations)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Cashiers>
            {
                List = currencies,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Cashiers> Add(CashiersDto cashiersDto)
        {
            var result = _mapper.Map<CashiersDto, MSS_DEF_Cashiers>(cashiersDto);
            await dataContext.MSS_DEF_Cashiers.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, CashiersDto cashiersDto)
        {
            var result = await dataContext.MSS_DEF_Cashiers.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(cashiersDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Cashiers.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Cashiers.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
