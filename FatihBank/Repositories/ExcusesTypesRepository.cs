using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class ExcusesTypesRepository : IExcusesTypesRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public ExcusesTypesRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_ATT_ExcusesTypes>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_ATT_ExcusesTypes.Count() / pageSize);

            var list = await dataContext.MSS_ATT_ExcusesTypes
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_ATT_ExcusesTypes>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_ATT_ExcusesTypes> Add(ExcusesTypesDto excusesTypesDto)
        {
            var result = _mapper.Map<ExcusesTypesDto, MSS_ATT_ExcusesTypes>(excusesTypesDto);
            await dataContext.MSS_ATT_ExcusesTypes.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, ExcusesTypesDto excusesTypesDto)
        {
            var result = await dataContext.MSS_ATT_ExcusesTypes.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(excusesTypesDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_ATT_ExcusesTypes.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_ATT_ExcusesTypes.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}