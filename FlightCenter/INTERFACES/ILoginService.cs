using System;
using System.Collections.Generic;
using System.Text;

namespace FlightCenter.INTERFACES
{
    interface ILoginService
    {
        bool TryLogin(string userName, string password, out ILoginToken token, out FacadeBase facade);
    }
}
