using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MNV.Core.Database;
using MNV.Core.Exceptions;
using MNV.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MNV.Queries.User
{
    /// <summary>
    /// It handles our Query, handler and response.
    /// We put those three in container for code discoverability purpose.
    /// 
    /// Benefits of using records is its immutable
    /// </summary>
    public static class GetUserById 
    {
        #region Query
        public record Query(long id) : IQuery;
        #endregion

        #region Handler
        public class GetUserByIdHandler : QueryHandler, IRequestHandler<Query, IRequestResponse>
        {
            public GetUserByIdHandler(IDataContext dataContext) : base(dataContext)
            {
            }
            public async Task<IRequestResponse> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _dataContext.User.Where(x => x.ID == request.id).FirstOrDefaultAsync();
                if (result is null)
                    throw new DataNoFoundException(ExceptionMessageConstants.DataNotFound);

                return new Response(result.ID, $"{result.LastName}, {result.FirstName}", result.Username, result.Email, result.Active);
            }
        }
        #endregion

        #region Response
        public record Response(long id, string fullname, string username, string email, bool isActive) : IRequestResponse;
        #endregion

    }
}
