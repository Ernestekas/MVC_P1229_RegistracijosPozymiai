using Microsoft.AspNetCore.Mvc;
using RegistracijosPozymiai.Dtos.Registrations;
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
        private readonly RegistrationsService _registrationsService;

        public RegistrationController(
            AttributesService attributesService, 
            ValuesService valuesService,
            RegistrationsService registrationsService)
        {
            _attributesService = attributesService;
            _valuesService = valuesService;
            _registrationsService = registrationsService;
        }

        public IActionResult All()
        {
            DisplayAll allReg = _registrationsService.GetAll();
            return View(allReg);
        }

        public IActionResult Add()
        {
            NewRegistration newRegistration = _attributesService.PrepareNewRegistration();
            return View(newRegistration);
        }
    }
}
