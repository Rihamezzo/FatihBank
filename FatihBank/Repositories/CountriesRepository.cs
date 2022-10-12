using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class CountriesRepository : ICountriesRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public CountriesRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Countries>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Countries.Count() / pageSize);

            var list = await dataContext.MSS_DEF_Countries.Include(x => x.stores)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Countries>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Countries> Add(CountriesDto countriesDto)
        {
            var result = _mapper.Map<CountriesDto, MSS_DEF_Countries>(countriesDto);
            await dataContext.MSS_DEF_Countries.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, CountriesDto countriesDto)
        {
            var result = await dataContext.MSS_DEF_Countries.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(countriesDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Countries.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Countries.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
