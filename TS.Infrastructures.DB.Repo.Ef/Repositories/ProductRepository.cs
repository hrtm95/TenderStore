using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class ProductRepository : IProductRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public ProductRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task Create(ProductDto productDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Product>(productDto);
            await _db.Products.AddAsync(record);
            try
            {
                await _db.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task Delete(int Id, CancellationToken cancellationToken)
        {
            var order = await _db.Products
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync(cancellationToken);
            order.IsDeleted = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Product>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.Products
               .AsNoTracking()
               .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(ProductDto productDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<Product>(_db.Set<Product>())
                .Where(x => x.Id == productDto.Id).FirstOrDefaultAsync();
            _mapper.Map(productDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
        public async Task Active(int productId, CancellationToken cancellationToken)
        {
            var record = await _db.Products
               .Where(x => x.Id == productId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task DeActive(int productId, CancellationToken cancellationToken)
        {
            var record = await _db.Products
               .Where(x => x.Id == productId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = false;
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}
