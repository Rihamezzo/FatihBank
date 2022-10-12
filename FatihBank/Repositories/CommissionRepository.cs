using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class CommissionRepository : ICommissionRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public CommissionRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Commission>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Commission.Count() / pageSize);

            var commissions = await dataContext.MSS_DEF_Commission.Include(x => x.account).Include(x => x.profitAccount)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Commission>
            {
                List = commissions,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Commission> Add(CommissionDto commissionDto)
        {
            var result = _mapper.Map<CommissionDto, MSS_DEF_Commission>(commissionDto);
            await dataContext.MSS_DEF_Commission.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, CommissionDto commissionDto)
        {
            var result = await dataContext.MSS_DEF_Commission.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(commissionDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Commission.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Commission.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
