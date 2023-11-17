using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class ShopStandReposiory : IShopStandReposiory
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;
        public ShopStandReposiory(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        public async Task<List<ShopStand>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.ShopStands
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            return records;
        }

        public async Task Update(ShopStandDto ShopStandDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<ShopStand>(_db.Set<ShopStand>())
                .Where(x => x.Id == ShopStandDto.Id).FirstOrDefaultAsync();
            _mapper.Map(ShopStandDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(int Id, CancellationToken cancellationToken)
        {
            var order = await _db.ShopStands
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync(cancellationToken);
            order.IsDeleted = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task Create(ShopStandDto boothDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<ShopStand>(boothDto);
            await _db.ShopStands.AddAsync(record);
            try
            {
                await _db.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public async Task Active(int ShopStandId, CancellationToken cancellationToken)
        {
            var record = await _db.ShopStands
               .Where(x => x.Id == ShopStandId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task DeActive(int ShopStandId, CancellationToken cancellationToken)
        {
            var record = await _db.ShopStands
               .Where(x => x.Id == ShopStandId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = false;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public Task<ShopStand> GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
