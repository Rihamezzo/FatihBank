using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class StoresRepository : IStoresRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public StoresRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Stores>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Stores.Count() / pageSize);

            var list = await dataContext.MSS_DEF_Stores.Include(x => x.country)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Stores>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Stores> Add(StoresDto storesDto)
        {
            var result = _mapper.Map<StoresDto, MSS_DEF_Stores>(storesDto);
            await dataContext.MSS_DEF_Stores.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, StoresDto storesDto)
        {
            var result = await dataContext.MSS_DEF_Stores.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(storesDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Stores.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Stores.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
