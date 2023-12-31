﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Contracts.Repository;
using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Common;

namespace TS.Infrastructures.DB.Repo.Ef
{
    public class AuctionInformationRpository : IAuctionInformationRpository
    {
        private readonly TSDbcontext _db;
        private readonly IMapper _mapper;

        public AuctionInformationRpository(TSDbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task Create(AuctionInformationDto auctionInformationDto, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<AuctionInformation>(auctionInformationDto);
            await _db.AuctionInformations.AddAsync(record);
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
            var order = await _db.AuctionInformations
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync(cancellationToken);
            order.IsDeleted = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<AuctionInformation>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _db.AuctionInformations
              .AsNoTracking()
              .ToListAsync(cancellationToken);
            return records;
        }

        public Task GetBy(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(AuctionInformationDto auctionInformationDto, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<AuctionInformation>(_db.Set<AuctionInformation>())
                .Where(x => x.Id == auctionInformationDto.Id).FirstOrDefaultAsync();
            _mapper.Map(auctionInformationDto, record);
            await _db.SaveChangesAsync(cancellationToken);
        }
        public async Task Active(int AuctionInformationId, CancellationToken cancellationToken)
        {
            var record = await _db.AuctionInformations
               .Where(x => x.Id == AuctionInformationId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = true;
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task DeActive(int AuctionInformationsId, CancellationToken cancellationToken)
        {
            var record = await _db.AuctionInformations
               .Where(x => x.Id == AuctionInformationsId)
               .FirstOrDefaultAsync(cancellationToken);
            record.IsActive = false;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
