using AutoMapper;
using FatihBank.Data;
using FatihBank.DTOs;
using FatihBank.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace FatihBank.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public UsersRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<PaginationResponse<MSS_DEF_Users>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Users.Count() / pageSize);

            var users =await dataContext.MSS_DEF_Users.Include(x => x.permissions)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Users>
            {
                List= users,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Users> Add(UsersDto usersDto)
        {
            var result = _mapper.Map<UsersDto, MSS_DEF_Users>(usersDto);

            byte[] salt = new byte[128 / 8];

            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            byte[] hashed = KeyDerivation.Pbkdf2(
                password: result.password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8);
            result.PasswordHash = hashed;
            result.PasswordSalt = salt;

            await dataContext.MSS_DEF_Users.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }
        public async Task Update(int id,UsersDto usersDto)
        {
            var result = await dataContext.MSS_DEF_Users.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(usersDto, result);
                await dataContext.SaveChangesAsync();
            }
        }

        public async Task Delete(int userId)
        {
            var result = await dataContext.MSS_DEF_Users.FirstOrDefaultAsync(e => e.Id == userId);
            if (result != null)
            {
                dataContext.MSS_DEF_Users.Remove(result);
                await dataContext.SaveChanges();
            }
        }
       

    }
}
