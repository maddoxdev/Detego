using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Detego.API.Context;
using Detego.API.Entity;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Detego.API.Application.Characteristics.Queries.GetStoreCharacts
{
    public class GetStoreCharactsHandler : IRequestHandler<GetStoreCharactsQuery, Characteristic>
    {
        private readonly StoreContext _context;

        public GetStoreCharactsHandler(StoreContext context)
        {
            _context = context;
        }

        public async Task<Characteristic> Handle(GetStoreCharactsQuery request, CancellationToken cancellationToken)
        {
            #region [Use repository pattern]

            var charact = await _context.Stores
                .Include(s => s.Characteristic)
                .Select(s => s.Characteristic)
                .FirstAsync();

            #endregion

            return charact;
        }
    }
}