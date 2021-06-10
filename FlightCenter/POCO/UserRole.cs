using System;
using System.Collections.Generic;
using System.Text;

namespace FlightCenter.POCO
{
    class UserRole
    {
        long Id { get; set; }
        string RoleName { get; set; }

        public UserRole()
        {
                
        }
        public UserRole(long id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }
    }
}
