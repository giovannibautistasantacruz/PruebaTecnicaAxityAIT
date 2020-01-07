using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiExamen.Models.CustomModels
{
    public class LoginResponse
    {
       public LoginResponse()
        {
            user = new Users();
        }
        public bool status { get; set; }
        public Users user { get; set;}
    }
}