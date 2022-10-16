using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class RegisterationFileRepository : IRegisterationFileRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public RegisterationFileRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_INF_RegisterationFile>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_INF_RegisterationFile.Count() / pageSize);

            var list = await dataContext.MSS_INF_RegisterationFile.Include(x => x.user).Include(x => x.ActionType).Include(x => x.account).Include(x => x.cashier).Include(x => x.currency).Include(x => x.exchange)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_INF_RegisterationFile>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_INF_RegisterationFile> Add(RegisterationFileDto registerationFileDto)
        {
            var result = _mapper.Map<RegisterationFileDto, MSS_INF_RegisterationFile>(registerationFileDto);
            await dataContext.MSS_INF_RegisterationFile.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, RegisterationFileDto registerationFileDto)
        {
            var result = await dataContext.MSS_INF_RegisterationFile.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(registerationFileDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_INF_RegisterationFile.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_INF_RegisterationFile.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}