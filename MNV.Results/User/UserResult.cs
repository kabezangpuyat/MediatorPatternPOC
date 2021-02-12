using System;
using System.Collections.Generic;
using System.Text;

namespace MNV.Results.User
{
    public class UserResult : IResult
    {
        public long UserID { get; set; }
        public Guid UserKey { get; set; }

        public long RoleID { get; set; }
        public Guid RoleKey { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string RoleName { get; set; }
        public bool IsUserActive { get; set; }
    }
}
