
using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class TransactionsRepository : ITransactionsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public TransactionsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Transactions>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Transactions.Count() / pageSize);

            var list = await dataContext.MSS_DEF_Transactions.Include(x => x.account).Include(x => x.exchange).Include(x => x.cashier)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Transactions>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Transactions> Add(TransactionsDto transactionsDto)
        {
            var result = _mapper.Map<TransactionsDto, MSS_DEF_Transactions>(transactionsDto);
            await dataContext.MSS_DEF_Transactions.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, TransactionsDto transactionsDto)
        {
            var result = await dataContext.MSS_DEF_Transactions.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(transactionsDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Transactions.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Transactions.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}