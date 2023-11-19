using AutoMapper;
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
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;


        public UserRepository(TSDbcontext db, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _db = db;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;

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
                };
            }
            user = new User
            {
                UserName = userDto.Email,
                Email = userDto.Email,

            };

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if (result.Succeeded)
            {
                if (userDto.Role == null)
                {
                    await _userManager.AddToRoleAsync(user, "Customer");
                }
                else
                {

                    await _userManager.AddToRoleAsync(user, "Customer");
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

        public async Task<User> GetBy(int Id, CancellationToken cancellationToken)
        {
            var User = await _db.Users.Where(x => x.Id == Id).FirstOrDefaultAsync(cancellationToken);
            return User;
        }

        public async Task Update(UserDto userDto, CancellationToken cancellationToken)
        {
            //try
            //{
            //    var record = await _mapper.ProjectTo<UserDto>(_db.Set<User>())
            //     .Where(x => x.Id == userDto.Id).FirstOrDefaultAsync();
            //    _mapper.Map(userDto, record);
            //    await _db.SaveChangesAsync(cancellationToken);
            //}
            //catch (Exception ex)
            //{

            //}



            var record = _mapper.Map<User>(userDto);
            _db.Attach(record).State = EntityState.Modified;
            try
            {
                await _db.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(record.Id))
                {
                    return;
                }
                else
                {
                    throw;
                }
            }

        }
        private bool UserExists(int id)
        {
            return (_db.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        public async Task<IdentityRole<int>> FindUser(int Id, CancellationToken cancellationToken)
        {
            var record = await _db.UserRoles.Where(x => x.UserId == Id).Include(p => p.RoleId)
             .FirstOrDefaultAsync(cancellationToken);
            var role = record.RoleId;

            return null;
        }
        public async Task<SignInResult> Login(UserDto userDto, CancellationToken cancellationToken)
            => await _signInManager.PasswordSignInAsync(userDto.Email, userDto.Password, true, false);
        public async Task<User> GetByEmail(string Email, CancellationToken cancellationToken)
        {
            var User = await _userManager.Users.Where(e => e.Email == Email).FirstOrDefaultAsync();
            return User;
        }
    }
}
