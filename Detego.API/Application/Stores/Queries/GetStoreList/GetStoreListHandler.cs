using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Detego.API.Application.Stores.Models;
using Detego.API.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Detego.API.App.Stores.Queries.GetStoreList
{
    public class GetStoreListHandler : IRequestHandler<GetStoreListQuery, IList<StoreViewModelDto>>
    {
        private readonly StoreContext _dbContex;

        public GetStoreListHandler(StoreContext dbCtx)
        {
            _dbContex = dbCtx;
        }

        public async Task<IList<StoreViewModelDto>> Handle(GetStoreListQuery request, CancellationToken cancellationToken)
        {
            return await _dbContex.Stores
                .Include(s => s.Manager)
                .Select(StoreViewModelDto.Projection)
                .ToListAsync();
        }
    }
}