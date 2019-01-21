using System;
using System.Collections.Generic;
using Detego.API.Application.Stores.Models;
using MediatR;

namespace Detego.API.App.Stores.Queries.GetStoreList
{
    public class GetStoreListQuery : IRequest<IList<StoreViewModelDto>>
    {
        
    }
}