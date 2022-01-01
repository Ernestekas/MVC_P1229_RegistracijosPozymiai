using Microsoft.EntityFrameworkCore;
using RegistracijosPozymiai.Data;
using RegistracijosPozymiai.Models;
using System.Collections.Generic;
using System.Linq;

namespace RegistracijosPozymiai.Repositories
{
    public class ValuesRepository: RepositoryBase<RegValue>
    {
        public ValuesRepository(DataContext context): base(context) { }

        public List<RegValue> GetAll()
        {
            return _context.RegValues.Include(v => v.ValueRegistrations).ToList();
        }

        public List<RegValue> GetByIdsList(List<int> valuesIds)
        {
            return GetAll().Where(v => valuesIds.Contains(v.Id)).ToList();
        }
    }
}
