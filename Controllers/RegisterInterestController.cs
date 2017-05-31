using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using resume_webapp.Models;

namespace resume_webapp.Controllers
{
    [Route("api/[controller]")]
    public class RegisterInterestController : Controller
    {
        [HttpPost("Register")]
        public async Task<string> RegisterInterest([FromBody] Register register)
        {
            return await Task.Run(()=> {
                {
                    if(string.IsNullOrWhiteSpace(register.Name))
                        return  "Please enter your name to get access.";
                    if(string.IsNullOrWhiteSpace(register.Email))
                        return "Email is mandatory to get the access code.";

                    return "Registration Successful!";
                }
            }
            );

        } 
    }
}
