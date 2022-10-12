using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class AddToMonthlyListRepository : IAddToMonthlyListRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public AddToMonthlyListRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_CUS_Add_To_Monthly_List>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_CUS_Add_To_Monthly_List.Count() / pageSize);

            var list = await dataContext.MSS_CUS_Add_To_Monthly_List.Include(x => x.account).Include(x => x.currency).Include(x => x.profitAccount)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_CUS_Add_To_Monthly_List>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_CUS_Add_To_Monthly_List> Add(AddToMonthlyListDto addToMonthlyListDto)
        {
            var result = _mapper.Map<AddToMonthlyListDto, MSS_CUS_Add_To_Monthly_List>(addToMonthlyListDto);
            await dataContext.MSS_CUS_Add_To_Monthly_List.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, AddToMonthlyListDto addToMonthlyListDto)
        {
            var result = await dataContext.MSS_CUS_Add_To_Monthly_List.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(addToMonthlyListDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_CUS_Add_To_Monthly_List.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_CUS_Add_To_Monthly_List.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}

