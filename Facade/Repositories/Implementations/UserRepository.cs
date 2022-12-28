using System;

namespace Facade.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        public void SomeUserOperation1()
        {
            Console.WriteLine("User Operation 1");
        }

        public void SomeUserOperation2()
        {
            Console.WriteLine("User Operation 2");
        }
    }
}
