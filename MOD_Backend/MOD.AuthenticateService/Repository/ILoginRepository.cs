using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Repository
{
    public interface ILoginRepository
    {
        bool UserLogin(string email, string pwd);
        bool MentorLogin(string email, string pwd);
    }
}
