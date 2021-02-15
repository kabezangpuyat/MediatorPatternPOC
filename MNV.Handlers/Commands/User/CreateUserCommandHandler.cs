using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MNV.Core.Database;
using MNV.Requests.Commands.User;
using MNV.Results;
using MNV.Results.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MNV.Handlers.Commands.User
{
    public class CreateUserCommandHandler : RequestHandler, IRequestHandler<CreateUserCommand, IResult>
    {
        public CreateUserCommandHandler(IDataContext dataContext,
          IMapper mapper) : base(dataContext, mapper)
        {
        }
        public async Task<IResult> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await  _dataContext.User.FirstOrDefaultAsync();
            //mmaper here
            return new UserResult();
        }
    }
}
