using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public ProductCategoryRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task Create(ProductCategoryDto productCategoryDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<ProductCategory>(productCategoryDto);
            await _db.ProductCategories.AddAsync(record);
            try
            {
                await _db.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task<List<ProductCategory>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.ProductCategories
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(ProductCategoryDto productCategoryDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<ProductCategory>(_db.Set<ProductCategory>())
                .Where(x => x.Id == productCategoryDto.Id).FirstOrDefaultAsync();
            _mapper.Map(productCategoryDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
