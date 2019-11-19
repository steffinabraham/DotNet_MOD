using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.AuthenticateService.Models;
using MOD.AuthenticateService.Repository;

namespace MOD.AuthenticateService.Controllers
{
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _repository;
        public LoginController(ILoginRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("Validate/{id}/{pwd}")]
        public Token Get(string email, string pwd)
        {
            if (_repository.UserLogin(email, pwd))
            {
                return new Token() { message = "User", token = GetToken() };
            }
            else if (_repository.MentorLogin(email, pwd))
            {
                return new Token() { message = "Mentor", token = GetToken() };
            }
            else if (email == "TechMakerz28" && pwd == "admin")
            {
                return new Token() { message = "Admin", token = "" };
            }
            else
            {
                return new Token() { message = "Invalid User/Mentor", token = "" };
            }
        }
        public string GetToken()
        {
            return "";
        }
    }
}


        