using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiExamen.Models.CustomModels;

namespace WebApiExamen.Controllers
{
    public class ValuesController : ApiController
    {
        private Models.ExamAxityEntities context = new Models.ExamAxityEntities();
        // GET api/values
        public IHttpActionResult Getproducts()
        {
            var products = context.Products.ToList();

            return Json(products);
        }

        // GET api/values/5
        public IHttpActionResult GetLogin(string user,string password)
        {
            try
            {
                var userData = context.Users.Where(s => s.pwd == password && s.user == user).FirstOrDefault();
                LoginResponse logn = new LoginResponse();
                logn.status = true;
                logn.user = userData;
                return Json(logn);
            }
            catch (Exception)
            {
                LoginResponse logn = new LoginResponse
                {
                    status = false
                };
                return Json(logn);
            }
            // var userData = context.Users.Select(s => s.pwd == password && s.user == user).FirstOrDefault();
            
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
