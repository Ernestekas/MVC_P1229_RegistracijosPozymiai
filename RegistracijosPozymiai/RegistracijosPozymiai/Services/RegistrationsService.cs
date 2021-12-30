using RegistracijosPozymiai.Dtos.Registrations;
using RegistracijosPozymiai.Models;
using RegistracijosPozymiai.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace RegistracijosPozymiai.Services
{
    public class RegistrationsService
    {
        private RegistrationsRepository _registrationsRepository;
        private AttributesRepository _attributesRepository;

        public RegistrationsService(
            RegistrationsRepository registrationsRepository
            , AttributesRepository attributesRepository)
        {
            _registrationsRepository = registrationsRepository;
            _attributesRepository = attributesRepository;
        }

        public DisplayAll GetAll()
        {
            DisplayAll result = new DisplayAll()
            {
                RegsIds = _registrationsRepository.GetAll().Select(r => r.Id).ToList()
            };

            return result;
        }

        public int Create()
        {
            return _registrationsRepository.Create();
        }

        public Registration PrepareForUpdate(int regId)
        {
            FormedRegistration formedReg = _registrationsRepository.GetById(regId);

            Registration reg = new Registration()
            {
                Attributes = _attributesRepository.GetAll(),
            };

            reg.AttributesIds = reg.Attributes.Select(a => a.Id).ToList();

            for(int i = 0; i < reg.Attributes.Count; i++)
            {
                // Pick attribute. It has regValues. Each value has id. 
                // formedReg has valueRegistration which has regValueId.
                // Selected RegValue.
                // Pick one value from attribute.RegValues
            }
            
            
            return null;
        }
    }
}
