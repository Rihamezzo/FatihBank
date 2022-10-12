using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class ChatListRepository : IChatListRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public ChatListRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_CHT_ChatList>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_CHT_ChatList.Count() / pageSize);

            var list = await dataContext.MSS_CHT_ChatList.Include(x => x.user1).Include(x => x.user2)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_CHT_ChatList>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_CHT_ChatList> Add(ChatListDto chatListDto)
        {
            var result = _mapper.Map<ChatListDto, MSS_CHT_ChatList>(chatListDto);
            await dataContext.MSS_CHT_ChatList.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, ChatListDto chatListDto)
        {
            var result = await dataContext.MSS_CHT_ChatList.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(chatListDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_CHT_ChatList.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_CHT_ChatList.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}