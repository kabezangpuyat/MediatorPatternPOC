using MediatR;
using MNV.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace MNV.Requests.Commands.User
{
    public class CreateUserCommand : IQuery
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    }
}
