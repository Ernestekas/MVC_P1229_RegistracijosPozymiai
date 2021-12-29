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
    }
}
