using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class AddressRepository : IAddressRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public AddressRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task Create(AddressDto addressDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Address>(addressDto);
            await _db.Addresses.AddAsync(record);
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
            var order = await _db.Addresses
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync(cancellationToken);
            order.IsDeleted = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Address>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.Addresses
               .AsNoTracking()
               .ToListAsync(cancellationToken);
            return records;
        }

        public async Task<AddressDto> GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(AddressDto addressDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<AddressDto>(_db.Set<AddressDto>())
                 .Where(x => x.Id == addressDto.Id).FirstOrDefaultAsync();
            _mapper.Map(addressDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
        public async Task Active(int addressId, CancellationToken cancellationToken)
        {
            var record = await _db.Addresses
               .Where(x => x.Id == addressId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task DeActive(int addressId, CancellationToken cancellationToken)
        {
            var record = await _db.Addresses
               .Where(x => x.Id == addressId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = false;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
