using System;
using Facade.Repositories.Interfaces;

namespace Facade.Repositories.Implementations
{
    public class AdminRepository : IAdminRepository
    {
        public void SomeAdminOperation1()
        {
            Console.WriteLine("Admin Operation 1");
        }

        public void SomeAdminOperation2()
        {
            Console.WriteLine("Admin Operation 2");
        }
    }
}
