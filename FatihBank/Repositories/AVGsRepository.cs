using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class AVGsRepository : IAVGsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public AVGsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_AVGs>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_AVGs.Count() / pageSize);

            var aVGs = await dataContext.MSS_DEF_AVGs.Include(x => x.currency)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_AVGs>
            {
                List = aVGs,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_AVGs> Add(AVGsDto aVGsDto)
        {
            var result = _mapper.Map<AVGsDto, MSS_DEF_AVGs>(aVGsDto);
            await dataContext.MSS_DEF_AVGs.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, AVGsDto aVGsDto)
        {
            var result = await dataContext.MSS_DEF_AVGs.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(aVGsDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_AVGs.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_AVGs.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
