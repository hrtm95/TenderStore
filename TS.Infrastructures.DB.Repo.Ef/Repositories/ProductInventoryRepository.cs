using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class ProductInventoryRepository : IProductInventoryRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public ProductInventoryRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task Create(ProductInventoryDto productInventoryDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<ProductInventory>(productInventoryDto);
            await _db.ProductInventory.AddAsync(record);
            try
            {
                await _db.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task<List<ProductInventory>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.ProductInventory
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(ProductInventoryDto productInventoryDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<ProductInventory>(_db.Set<ProductInventory>())
                .Where(x => x.Id == productInventoryDto.Id).FirstOrDefaultAsync();
            _mapper.Map(productInventoryDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
