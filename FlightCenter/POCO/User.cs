using System;
using System.Collections.Generic;
using System.Text;

namespace FlightCenter.POCO
{
    class User:IPoco
    {
        long Id { get; set; }
        string UserName { get; set; }
        string Password { get; set; }   
        string Email { get; set; }
        long UserRoleId { get; set; }

        UserRole userRole;

        public User()
        {

        }

        public User(long id, string userName, string password, string email, long userRoleId)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Email = email;
            UserRoleId = userRoleId;
        }

    }
}
