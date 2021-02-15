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

namespace MNV.Queries.UserRole
{
    /// <summary>
    /// It handles our Query, handler and response.
    /// We put those three in container for code discoverability purpose.
    /// 
    /// Benefits of using records is its immutable
    /// </summary>
    public static class GetUserRoleByUserId
    {
        #region Query
        public record Query(long userId) : IRequest<Response>;
        #endregion

        #region Handler
        public class Handler : QueryHandler, IRequestHandler<Query, Response>
        {
            public Handler(IDataContext dataContext) : base(dataContext)
            {
            }
            public async Task<Response> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _dataContext.UserRole
                        .Where(x => x.UserID == request.userId)
                        .Include(x=>x.User)
                        .Include(x=>x.Role)
                        .FirstOrDefaultAsync();

                return result == null ? null : new Response(result.UserID,result.RoleID,result.Role.Name,$"{result.User.LastName}, {result.User.FirstName}",result.Active);
            }
        }
        #endregion

        #region Response
        public record Response(long userID, long roleID, string roleName, string fullname, bool active);
        #endregion

    }
}
