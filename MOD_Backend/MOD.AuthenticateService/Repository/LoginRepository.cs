using MOD.AuthenticateService.Context;
using MOD.AuthenticateService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Repository
{
    public class LoginRepository: ILoginRepository
    {
            private readonly LoginContext _context;
            public LoginRepository(LoginContext context)
            {
                _context = context;
            }
            public bool MentorLogin(string email, string pwd)
        {
            Mentor obj = _context.Mentor.SingleOrDefault(data => data.Email == email && data.Password == pwd);
            if (obj != null)
                return true;
            else
                return false;
        }

        public bool UserLogin(string email, string pwd)
        {
            User obj = _context.User.SingleOrDefault(data => data.Email == email && data.Password == pwd);
            if (obj != null)
                return true;
            else
                return false;
        }


    }
}
