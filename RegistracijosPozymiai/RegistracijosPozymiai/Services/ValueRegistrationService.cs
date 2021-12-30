using RegistracijosPozymiai.Models;
using RegistracijosPozymiai.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                ValueRegistration valReg = new ValueRegistration()
                {
                    FormedRegistrationId = regId,
                    RegValueId = valId
                };
                valsRegs.Add(valReg);
            }


        }
    }
}
