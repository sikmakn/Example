using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models.Context;

namespace WebApplication1.Models
{
    public class UserDbInitializer : DropCreateDatabaseAlways<Context.UserContext>
    {
        protected override void Seed(UserContext context)
        {
            context.Users.Add(new User { Name = "Sikmak", Password = "SuperStar"});
            context.Users.Add(new User { Name = "Admin", Password = "SuperPuperStar"});
            context.Users.Add(new User { Name = "Third", Password = "ThirdStar"});
            base.Seed(context);
        }
    }
}