using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class GroupsRepository : IGroupsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public GroupsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Groups>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Groups.Count() / pageSize);

            var list = await dataContext.MSS_DEF_Groups
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Groups>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Groups> Add(GroupsDto groupsDto)
        {
            var result = _mapper.Map<GroupsDto, MSS_DEF_Groups>(groupsDto);
            await dataContext.MSS_DEF_Groups.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, GroupsDto groupsDto)
        {
            var result = await dataContext.MSS_DEF_Groups.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(groupsDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Groups.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Groups.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}