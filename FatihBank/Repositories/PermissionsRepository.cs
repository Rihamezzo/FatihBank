using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class PermissionsRepository : IPermissionsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public PermissionsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Permissions>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Permissions.Count() / pageSize);

            var list = await dataContext.MSS_DEF_Permissions.Include(x => x.user).Include(x => x.module1)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Permissions>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Permissions> Add(PermissionsDto permissionsDto)
        {
            var result = _mapper.Map<PermissionsDto, MSS_DEF_Permissions>(permissionsDto);
            await dataContext.MSS_DEF_Permissions.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, PermissionsDto permissionsDto)
        {
            var result = await dataContext.MSS_DEF_Permissions.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(permissionsDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Permissions.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Permissions.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}