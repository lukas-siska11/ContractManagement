using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Auth
{
    public class AuthApplicationService : IAuthApplicationService
    {
        public async Task<bool> SignIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SignOut()
        {
            throw new NotImplementedException();
        }
    }
}
