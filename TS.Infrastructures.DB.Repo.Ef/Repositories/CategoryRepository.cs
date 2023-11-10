using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public CategoryRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task Create(CategoryDto categoryDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Category>(categoryDto);
            await _db.Categories.AddAsync(record);
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
            var order = await _db.Categories
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync(cancellationToken);
            order.IsDeleted = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Category>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.Categories
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(CategoryDto categoryDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<Category>(_db.Set<Category>())
                .Where(x => x.Id == categoryDto.Id).FirstOrDefaultAsync();
            _mapper.Map(categoryDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
                public async Task Active(int CategoryId, CancellationToken cancellationToken)
        {
            var record = await _db.Categories
               .Where(x => x.Id == CategoryId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task DeActive(int CategoriesId, CancellationToken cancellationToken)
        {
            var record = await _db.Categories
               .Where(x => x.Id == CategoriesId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = false;
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}
