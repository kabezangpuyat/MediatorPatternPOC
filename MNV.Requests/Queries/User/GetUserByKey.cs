using MediatR;
using MNV.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace MNV.Requests.Queries.User
{
    public class GetUserByKey : IQuery
    {
        public Guid Key { get; set; }
    }
}
