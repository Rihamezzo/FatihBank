using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class VouchersRepository : IVouchersRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public VouchersRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Vouchers>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Vouchers.Count() / pageSize);

            var list = await dataContext.MSS_DEF_Vouchers.Include(x => x.transaction)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Vouchers>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Vouchers> Add(VouchersDto vouchersDto)
        {
            var result = _mapper.Map<VouchersDto, MSS_DEF_Vouchers>(vouchersDto);
            await dataContext.MSS_DEF_Vouchers.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, VouchersDto vouchersDto)
        {
            var result = await dataContext.MSS_DEF_Vouchers.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(vouchersDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Vouchers.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Vouchers.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}