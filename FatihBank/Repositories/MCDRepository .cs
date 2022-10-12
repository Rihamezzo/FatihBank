using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class MCDRepository : IMCDRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public MCDRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_MCD>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_MCD.Count() / pageSize);

            var list = await dataContext.MSS_DEF_MCD.Include(x => x.account1).Include(x => x.account2).Include(x => x.profitAccount)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_MCD>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_MCD> Add(MCDDto mCDDto)
        {
            var result = _mapper.Map<MCDDto, MSS_DEF_MCD>(mCDDto);
            await dataContext.MSS_DEF_MCD.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, MCDDto mCDDto)
        {
            var result = await dataContext.MSS_DEF_MCD.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(mCDDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_MCD.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_MCD.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
