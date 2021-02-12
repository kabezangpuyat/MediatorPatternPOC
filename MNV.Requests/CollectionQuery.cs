using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using MNV.Results;

namespace MNV.Requests
{
    public class CollectionQuery : IRequest<CollectionResult>
    {
        //TODO: We can add filters, paging etc
    }
}
