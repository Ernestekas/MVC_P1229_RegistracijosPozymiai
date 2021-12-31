﻿using Microsoft.AspNetCore.Mvc;
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
        private readonly RegistrationsService _registrationsService;
        private readonly ValueRegistrationService _valueRegistrationService;

        public RegistrationController(
            AttributesService attributesService,
            RegistrationsService registrationsService,
            ValueRegistrationService valueRegistrationService)
        {
            _attributesService = attributesService;
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
            Registration newRegistration = _attributesService.PrepareNewRegistration();
            return View(newRegistration);
        }

        [HttpPost]
        public IActionResult Add(Registration registration)
        {
            int regId = _registrationsService.Create();
            _valueRegistrationService.Create(regId, registration.SelectedValuesIds);

            return RedirectToAction(nameof(All));
        }

        public IActionResult Update(int regId)
        {
            Registration update = _registrationsService.PrepareForUpdate(regId);
            return View(update);
        }
    }
}
