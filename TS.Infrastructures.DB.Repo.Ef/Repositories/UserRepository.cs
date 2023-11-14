﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class UserRepository : IUserRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public UserRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<IdentityResult> Create(UserDto userDto, CancellationToken cancellationToken)
        {
            var user = new User();
            if (userDto.Role == "Customer")
            {
                user = new User
                {
                    UserName = userDto.Email,
                    Email = userDto.Email,

                };
            }
            if (userDto.Role == "Admin")
            {
                user = new User
                {
                    UserName = userDto.Email,
                    Email = userDto.Email,
                };
            }
            if (userDto.Role == "Seller")
            {
                user = new User
                {

                    UserName = userDto.Email,
                    Email = userDto.Email,
                    PictureId = 1,
                    Seller = new Seller()
                    {
                        SellerName = "علی",
                        AddressId = 2,
                        PictureId = 2,
                        MedalId = 2,

                    }
                };
            }

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if (result.Succeeded)
            {
                if (userDto.Role == null)
                {
                    await _userManager.AddToRoleAsync(user, "Customer");
                }
                else
                {

                    await _userManager.AddToRoleAsync(user, userDto.Role);
                }

            }
            return result;
        }


        public async Task Delete(int Id, CancellationToken cancellationToken)
        {
            var record = await _db.Users
                           .Where(x => x.Id == Id)
                           .FirstOrDefaultAsync(cancellationToken);
            record.IsDeleted = true;
            await _db.SaveChangesAsync(cancellationToken);
        }
        public async Task Active(int userId, CancellationToken cancellationToken)
        {
            var record = await _db.Users
               .Where(x => x.Id == userId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task DeActive(int userId, CancellationToken cancellationToken)
        {
            var record = await _db.Users
               .Where(x => x.Id == userId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = false;
            await _db.SaveChangesAsync(cancellationToken);
        }


        public async Task<List<User>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.Users
             .AsNoTracking()
             .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(UserDto userDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<User>(_db.Set<User>())
                 .Where(x => x.Id == userDto.Id).FirstOrDefaultAsync();
            _mapper.Map(userDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }


    }
}
