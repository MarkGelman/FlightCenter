using FlightCenter.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightCenter
{
    class LoginService:ILoginService
    {
        private IAirlineCompanyDAO _airlineDAO;
        private ICustomerDAO _customerDAO;
        private IAdministratorDAO _adminDAO;
        private IUserDAO _userDAO;

        public bool TryLogin(string userName, string password, out ILoginToken token, out FacadeBase facade)
        {
            throw new NotImplementedException();
        }
    }
}
