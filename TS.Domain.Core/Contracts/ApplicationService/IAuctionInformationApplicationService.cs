using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Contracts.ApplicationService
{
    public interface IAuctionInformationApplicationService
    {
        Task<AuctionInformation> GetBy(int id, CancellationToken cancellationToken);
        Task<List<AuctionInformation>> GetAll(CancellationToken cancellationToken);
        Task Create(double price, CancellationToken cancellationToken);
    }
}
