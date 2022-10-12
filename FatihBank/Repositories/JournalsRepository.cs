using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class JournalsRepository : IJournalsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public JournalsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Journals>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Journals.Count() / pageSize);

            var list = await dataContext.MSS_DEF_Journals.Include(x => x.details)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Journals>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Journals> Add(JournalsDto journalsDto)
        {
            var result = _mapper.Map<JournalsDto, MSS_DEF_Journals>(journalsDto);
            await dataContext.MSS_DEF_Journals.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, JournalsDto journalsDto)
        {
            var result = await dataContext.MSS_DEF_Journals.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(journalsDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Journals.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Journals.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }

    public class JournalsDetailsRepository : IJournalsDetailsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public JournalsDetailsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_JOU_Details>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_JOU_Details.Count() / pageSize);

            var list = await dataContext.MSS_JOU_Details.Include(x => x.customer).Include(x =>x.account)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_JOU_Details>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_JOU_Details> Add(JournalsDetailsDto journalsDetailsDto)
        {
            var result = _mapper.Map<JournalsDetailsDto, MSS_JOU_Details>(journalsDetailsDto);
            await dataContext.MSS_JOU_Details.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, JournalsDetailsDto journalsDetailsDto)
        {
            var result = await dataContext.MSS_JOU_Details.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(journalsDetailsDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_JOU_Details.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_JOU_Details.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
