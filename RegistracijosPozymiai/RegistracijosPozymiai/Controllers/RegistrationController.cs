using Microsoft.AspNetCore.Mvc;
using RegistracijosPozymiai.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistracijosPozymiai.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly AttributesService _attributesService;
        private readonly ValuesService _valuesService;

        public RegistrationController(AttributesService attributesService, ValuesService valuesService)
        {
            _attributesService = attributesService;
            _valuesService = valuesService;
        }

        public IActionResult All()
        {
            return View();
        }
    }
}
