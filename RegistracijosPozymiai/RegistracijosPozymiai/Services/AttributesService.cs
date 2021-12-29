using RegistracijosPozymiai.Dtos.Registrations;
using RegistracijosPozymiai.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosPozymiai.Services
{
    public class AttributesService
    {
        private AttributesRepository _attributesRepository;

        public AttributesService(AttributesRepository attributesRepository)
        {
            _attributesRepository = attributesRepository;
        }

        public NewRegistration PrepareNewRegistration()
        {
            NewRegistration result = new NewRegistration()
            {
                Attributes = _attributesRepository.GetAll()
            };

            return result;
        }
    }
}
