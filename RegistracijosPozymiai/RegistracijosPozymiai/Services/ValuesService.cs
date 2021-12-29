using RegistracijosPozymiai.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosPozymiai.Services
{
    public class ValuesService
    {
        private ValuesRepository _valuesRepository;

        public ValuesService(ValuesRepository valuesRepository)
        {
            _valuesRepository = valuesRepository;
        }
    }
}
