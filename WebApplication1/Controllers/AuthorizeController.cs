using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Models.Context;

namespace WebApplication1.Controllers
{
    public class AuthorizeController : ApiController
    {
        UserContext db = new UserContext();
        //SET home/
        [HttpPost]
        public Models.UserViewModels Post(Models.UserViewModels value)
        {
            Console.WriteLine(value);
            return value;
        }
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.Users;
        }
    }
}