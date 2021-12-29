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
    public class AttributesRepository
    {
        private DataContext _context;
        public AttributesRepository(DataContext context)
        {
            _context = context;
        }

        public List<RegAttribute> GetAll()
        {
            return _context.RegAttributes.Include(a => a.RegistrationValues).ToList();
        }
    }
}
