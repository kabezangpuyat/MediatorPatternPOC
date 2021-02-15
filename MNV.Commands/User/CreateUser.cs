using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MNV.Core.Database;
using MNV.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MNV.Commands.User
{
    /// <summary>
    /// It handles our Query, handler and response.
    /// We put those three in container for code discoverability purpose.
    /// 
    /// Benefits of using records is its immutable
    /// </summary>
    public static class CreateUser
    {
        #region Command
        public record Command(UserViewModel model) : IRequest<Response>;
        #endregion

        #region Handler
        public class Handler : CommandHandler, IRequestHandler<Command, Response>
        {
            public Handler(IDataContext dataContext, IMapper mapper) : base(dataContext, mapper)
            {
            }
            public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
            {
                var data = _mapper.Map<Domain.Entities.User>(request.model);
                _dataContext.User.Add(data);
                await _dataContext.SaveChangesAsync()
                    .ConfigureAwait(false);

                var result = _mapper.Map<UserViewModel>(data);

                return result == null ? null : new Response(result);
            }
        }
        #endregion

        #region Response
        public record Response(UserViewModel user);
        #endregion

    }
}
