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
    public class ValuesRepository
    {
        private DataContext _context;
        public ValuesRepository(DataContext context)
        {
            _context = context;
        }

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
