using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class SoldRepository : ISoldRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public SoldRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task Create(SoldGoodsDto soldDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<SoldGoods>(soldDto);
            await _db.SoldGoods.AddAsync(record);
            try
            {
                await _db.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task<List<SoldGoods>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.SoldGoods
             .AsNoTracking()
             .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(SoldGoodsDto soldDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<SoldGoods>(_db.Set<SoldGoods>())
                 .Where(x => x.Id == soldDto.Id).FirstOrDefaultAsync();
            _mapper.Map(soldDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
