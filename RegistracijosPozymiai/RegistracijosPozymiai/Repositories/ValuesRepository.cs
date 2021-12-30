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
            return null;
        }
    }
}
