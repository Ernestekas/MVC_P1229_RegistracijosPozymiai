using RegistracijosPozymiai.Data;
using RegistracijosPozymiai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosPozymiai.Repositories
{
    public class ValueRegistrationRepository
    {
        private DataContext _context;
        public ValueRegistrationRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(List<ValueRegistration> valuesRegistration)
        {
            _context.ValueRegistrations.AddRange(valuesRegistration);
            _context.SaveChanges();
        }
    }
}
