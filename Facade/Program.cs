using System;
using Facade.Facades.Implementations;
using Facade.Facades.Interfaces;
using Facade.Repositories.Implementations;

namespace Facade
{
    internal class Program
    {
        private static void Main()
        {
            IAdminFacade adminFacade = new AdminFacade(new AdminRepository());
            IUserFacade userFacade = new UserFacade(new UserRepository());
            IAccountFacade accountFacade = new AccountFacade(adminFacade, userFacade);

            adminFacade.SomeAdminOperation();
            userFacade.SomeUserOperation();

            Console.WriteLine("------------------");

            accountFacade.SomeAccountOperation();

            Console.ReadKey();
        }
    }
}
