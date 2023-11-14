using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Services.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerService;
        public CustomerService(ICustomerRepository repository)
        {
            _customerService = repository;
        }
        public async Task Active(int Id, CancellationToken cancellationToken)
        {
            await _customerService.Active(Id, cancellationToken);
        }

        public async Task Create(CustomerDto customerDto, CancellationToken cancellationToken)
            => await _customerService.Create(customerDto, cancellationToken);

        public async Task DeActive(int Id, CancellationToken cancellationToken)
        {
            await _customerService.DeActive(Id, cancellationToken);
        }

        public async Task Delete(int Id, CancellationToken cancellationToken)
            => await _customerService.Delete(Id, cancellationToken);

        public async Task<List<Customer>> GetAll(CancellationToken cancellationToken)
        => await _customerService.GetAll(cancellationToken);

        public async Task<Customer> GetBy(int Id, CancellationToken cancellationToken)
        => await _customerService.GetBy(Id, cancellationToken);

        public async Task Update(CustomerDto customerDto, CancellationToken cancellationToken)
        => await _customerService.Update(customerDto, cancellationToken);
    }
}

