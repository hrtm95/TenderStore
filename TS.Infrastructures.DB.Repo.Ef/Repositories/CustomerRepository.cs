using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public CustomerRepository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public Task Active(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(CustomerDto customerDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Customer>(customerDto);
            await _db.Customer.AddAsync(record);
            try
            {
                await _db.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public Task DeActive(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int Id, CancellationToken cancellationToken)
        {
            var User = await _db.Customer.Where(x => x.Id == Id).FirstOrDefaultAsync(cancellationToken);
            User.IsDeleted = true;
            await _db.SaveChangesAsync();
        }

        public async Task<List<Customer>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.Customer
                .AsNoTracking()
                .Where(x => x.IsDeleted == false)
                .ToListAsync(cancellationToken);
            return records;
        }

        public async Task<Customer> GetBy(int Id, CancellationToken cancellationToken)
        {
            var Customer = await _db.Customer.Where(x => x.Id == Id).FirstOrDefaultAsync(cancellationToken);
            return Customer;
        }

        public async Task Update(CustomerDto customerDto, CancellationToken cancellationToken)
        {
            var record = await _db.Customer
                .Where(x => x.Id == customerDto.Id)
                .FirstOrDefaultAsync();
            _mapper.Map(customerDto, record);
            try
            {
                await _db.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
