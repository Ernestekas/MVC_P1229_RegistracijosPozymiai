using RegistracijosPozymiai.Data;
using RegistracijosPozymiai.Models;
using System.Collections.Generic;
using System.Linq;

namespace RegistracijosPozymiai.Repositories
{
    public class ValueRegistrationRepository
    {
        private DataContext _context;
        public ValueRegistrationRepository(DataContext context)
        {
            _context = context;
        }

        public List<ValueRegistration> GetAll(int? regId)
        {
            List<ValueRegistration> result = new List<ValueRegistration>();

            if(regId == null)
            {
                result = _context.ValueRegistrations.ToList();
            }
            else
            {
                result = _context.ValueRegistrations.Where(vr => vr.FormedRegistrationId == regId).ToList();
            }

            return result;
        }
        public void Create(List<ValueRegistration> valuesRegistration)
        {
            _context.ValueRegistrations.AddRange(valuesRegistration);
            _context.SaveChanges();
        }

        public void Delete(List<ValueRegistration> valsReg)
        {
            _context.ValueRegistrations.RemoveRange(valsReg);
            _context.SaveChanges();
        }
    }
}
