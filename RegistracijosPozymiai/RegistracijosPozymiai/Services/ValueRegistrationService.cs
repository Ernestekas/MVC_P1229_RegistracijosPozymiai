using RegistracijosPozymiai.Models;
using RegistracijosPozymiai.Repositories;
using System.Collections.Generic;

namespace RegistracijosPozymiai.Services
{
    public class ValueRegistrationService
    {
        private ValueRegistrationRepository _valueRegistrationRepository;

        public ValueRegistrationService(ValueRegistrationRepository valueRegistrationRepository)
        {
            _valueRegistrationRepository = valueRegistrationRepository;
        }

        public void Create(int regId, List<int> selectedValuesIds)
        {
            List<ValueRegistration> valsRegs = new List<ValueRegistration>();

            foreach(var valId in selectedValuesIds)
            {
                if(valId != 0)
                {
                    ValueRegistration valReg = new ValueRegistration()
                    {
                        FormedRegistrationId = regId,
                        RegValueId = valId
                    };
                    valsRegs.Add(valReg);
                }
            }
            _valueRegistrationRepository.Create(valsRegs);
        }

        public void Update(int regId, List<int> selectedValuesIds)
        {
            List<ValueRegistration> oldValsReg = _valueRegistrationRepository.GetAll(regId);

            _valueRegistrationRepository.Delete(oldValsReg);
            Create(regId, selectedValuesIds);
        }
    }
}
