using RegistracijosPozymiai.Dtos.Registrations;
using RegistracijosPozymiai.Repositories;
using System.Linq;

namespace RegistracijosPozymiai.Services
{
    public class RegistrationsService
    {
        private RegistrationsRepository _registrationsRepository;

        public RegistrationsService(RegistrationsRepository registrationsRepository)
        {
            _registrationsRepository = registrationsRepository;
        }

        public DisplayAll GetAll()
        {
            DisplayAll result = new DisplayAll()
            {
                RegsIds = _registrationsRepository.GetAll().Select(r => r.Id).ToList()
            };

            return result;
        }
    }
}
