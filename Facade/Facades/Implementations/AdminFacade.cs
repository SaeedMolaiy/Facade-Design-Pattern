using Facade.Facades.Interfaces;
using Facade.Repositories.Interfaces;

namespace Facade.Facades.Implementations
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. The Facade is also responsible
    // for managing their lifecycle. All of this shields the client from the
    // undesired complexity of the subsystem.
    public class AdminFacade : IAdminFacade
    {
        private readonly IAdminRepository _adminRepository;

        public AdminFacade(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public void SomeAdminOperation()
        {
            _adminRepository.SomeAdminOperation1();
            _adminRepository.SomeAdminOperation2();
        }

    }
}
