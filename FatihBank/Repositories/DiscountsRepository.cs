using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class DiscountsRepository : IDiscountsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public DiscountsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_ATT_Discounts>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_ATT_Discounts.Count() / pageSize);

            var list = await dataContext.MSS_ATT_Discounts.Include(x => x.employee)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_ATT_Discounts>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_ATT_Discounts> Add(DiscountsDto discountsDto)
        {
            var result = _mapper.Map<DiscountsDto, MSS_ATT_Discounts>(discountsDto);
            await dataContext.MSS_ATT_Discounts.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, DiscountsDto discountsDto)
        {
            var result = await dataContext.MSS_ATT_Discounts.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(discountsDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_ATT_Discounts.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_ATT_Discounts.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}