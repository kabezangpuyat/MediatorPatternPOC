using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MNV.Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MNV.Queries.Role
{
    /// <summary>
    /// It handles our Query, handler and response.
    /// We put those three in container for code discoverability purpose.
    /// 
    /// Benefits of using records is its immutable
    /// </summary>
    public static class GetRoleById
    {
        #region Query
        public record Query(long id) : IQuery;
        #endregion

        #region Handler
        public class Handler : QueryHandler, IRequestHandler<Query, IRequestResponse>
        {
            public Handler(IDataContext dataContext) : base(dataContext)
            {
            }
            public async Task<IRequestResponse> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _dataContext.Role.Where(x => x.ID == request.id).FirstOrDefaultAsync();

                return result == null ? null : new Response(result.ID, result.Name, result.Description, result.Active);
            }
        }
        #endregion

        #region Response
        public record Response(long id, string name, string desciption, bool active) : IRequestResponse;
        #endregion

    }
}
