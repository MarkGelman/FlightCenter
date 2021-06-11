using System;
using System.Collections.Generic;
using System.Text;

namespace FlightCenter
{
    class LoginToken <T> where T:IUser
    {
        public T User { get; set; }
    }
}
