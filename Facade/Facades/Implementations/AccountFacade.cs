using Facade.Facades.Interfaces;

namespace Facade.Facades.Implementations
{
    public class AccountFacade : IAccountFacade
    {
        private readonly IAdminFacade _adminFacade;
        private readonly IUserFacade _userFacade;

        public AccountFacade(IAdminFacade adminFacade, IUserFacade userFacade)
        {
            _adminFacade = adminFacade;
            _userFacade = userFacade;
        }

        public void SomeAccountOperation()
        {
            _adminFacade.SomeAdminOperation();
            _userFacade.SomeUserOperation();
        }
    }
}
