using System.Collections.Generic;

namespace SwaggerV2.API.Authentication
{
    public class UsersBL
    {
        public List<User> GetUsers() =>
            new List<User>
            {
                new User()
                {
                    ID = 101,
                    UserName = "MaleUser",
                    Password = "123456"
                }, 
                new User() 
                {
                    ID = 102,
                    UserName = "FemaleUser",
                    Password = "abcdef"
                }, 
                new User() {
                    ID = 103,
                    UserName = "user",
                    Password = "password"
                }
            };
    }
}