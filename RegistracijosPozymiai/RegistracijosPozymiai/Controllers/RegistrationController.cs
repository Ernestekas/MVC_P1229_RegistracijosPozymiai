using Microsoft.AspNetCore.Mvc;
using RegistracijosPozymiai.Dtos.Registrations;
using RegistracijosPozymiai.Models;
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
        private readonly ValueRegistrationService _valueRegistrationService;

        public RegistrationController(
            AttributesService attributesService,
            ValuesService valuesService,
            RegistrationsService registrationsService,
            ValueRegistrationService valueRegistrationService)
        {
            _attributesService = attributesService;
            _valuesService = valuesService;
            _registrationsService = registrationsService;
            _valueRegistrationService = valueRegistrationService;
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

        [HttpPost]
        public IActionResult Add(NewRegistration registration)
        {
            int regId = _registrationsService.Create();
            _valueRegistrationService.Create(regId, registration.SelectedValuesIds);

            return RedirectToAction(nameof(All));
        }

        public IActionResult Update(int regId)
        {

            return View();
        }
    }
}
