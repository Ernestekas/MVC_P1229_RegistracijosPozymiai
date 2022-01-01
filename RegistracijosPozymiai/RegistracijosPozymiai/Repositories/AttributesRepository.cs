using Microsoft.EntityFrameworkCore;
using RegistracijosPozymiai.Data;
using RegistracijosPozymiai.Models;
using System.Collections.Generic;
using System.Linq;

namespace RegistracijosPozymiai.Repositories
{
    public class AttributesRepository: RepositoryBase<RegAttribute>
    {
        public AttributesRepository(DataContext context): base(context) { }

        public List<RegAttribute> GetAll()
        {
            return _context.RegAttributes.Include(a => a.RegistrationValues).ToList();
        }
    }
}
