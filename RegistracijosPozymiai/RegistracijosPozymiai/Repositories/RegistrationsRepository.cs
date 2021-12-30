using Microsoft.EntityFrameworkCore;
using RegistracijosPozymiai.Data;
using RegistracijosPozymiai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosPozymiai.Repositories
{
    public class RegistrationsRepository
    {
        private DataContext _context;
        public RegistrationsRepository(DataContext context)
        {
            _context = context;
        }

        public List<FormedRegistration> GetAll()
        {
            return _context.FormedRegistrations.ToList();
        }

        public int Create()
        {
            FormedRegistration newReg = new FormedRegistration();
            _context.Add(newReg);
            _context.SaveChanges();
            return newReg.Id;
        }
    }
}
