using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticateAPI.Services.Interfaces
{
    public interface IAuthenticateService
    {
        Task<bool> CheckCredentials(string email, string password);
    }
}
