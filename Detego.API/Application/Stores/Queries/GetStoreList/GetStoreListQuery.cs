using Detego.API.Application.Stores.Models;
using MediatR;
using System.Collections.Generic;

namespace Detego.API.App.Stores.Queries.GetStoreList
{
    public class GetStoreListQuery : IRequest<IList<StoreViewModelDto>>
    {
        
    }
}