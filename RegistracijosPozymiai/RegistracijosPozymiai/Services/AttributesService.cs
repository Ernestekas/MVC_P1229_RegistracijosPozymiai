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

            result.AttributesIds = result.Attributes.Select(a => a.Id).ToList();

            foreach(var att in result.Attributes)
            {
                if(att.RegistrationValues != null)
                {
                    if(att.RegistrationValues.Count > 0)
                    {
                        result.AttributesSelectedValues.Add(att.RegistrationValues[0]);
                        result.SelectedValuesIds.Add(att.RegistrationValues[0].Id);
                    }
                    else
                    {
                        result.AttributesSelectedValues.Add(null);
                        result.SelectedValuesIds.Add(0);
                    }
                }
                else
                {
                    result.AttributesSelectedValues.Add(null);
                }
            }

            return result;
        }
    }
}
