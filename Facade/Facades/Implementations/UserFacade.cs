using Facade.Facades.Interfaces;
using Facade.Repositories.Implementations;

namespace Facade.Facades.Implementations
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. The Facade is also responsible
    // for managing their lifecycle. All of this shields the client from the
    // undesired complexity of the subsystem.
    public class UserFacade : IUserFacade
    {
        private readonly IUserRepository _userRepository;

        public UserFacade(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void SomeUserOperation()
        {
            _userRepository.SomeUserOperation1();
            _userRepository.SomeUserOperation2();
        }
    }
}
