using Detego.API.Application.Stores.Models;
using Detego.API.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Detego.API.App.Stores.Queries.GetStoreList
{
    public class GetStoreListHandler : IRequestHandler<GetStoreListQuery, IList<StoreViewModelDto>>
    {
        private readonly StoreContext _contex;

        public GetStoreListHandler(StoreContext context)
        {
            _contex = context;
        }

        public async Task<IList<StoreViewModelDto>> Handle(GetStoreListQuery request, CancellationToken cancellationToken)
        {
            return await _contex.Stores
                .Include(s => s.Manager)
                .Select(StoreViewModelDto.Projection)
                .ToListAsync();
        }
    }
}