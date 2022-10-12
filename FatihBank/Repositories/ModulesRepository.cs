
using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class ModulesRepository : IModulesRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public ModulesRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Modules>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Modules.Count() / pageSize);

            var list = await dataContext.MSS_DEF_Modules.Include(x => x.permissions)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Modules>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Modules> Add(ModulesDto modulesDto)
        {
            var result = _mapper.Map<ModulesDto, MSS_DEF_Modules>(modulesDto);
            await dataContext.MSS_DEF_Modules.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, ModulesDto modulesDto)
        {
            var result = await dataContext.MSS_DEF_Modules.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(modulesDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Modules.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Modules.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}