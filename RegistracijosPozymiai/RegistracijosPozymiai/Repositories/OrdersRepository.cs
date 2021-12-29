using RegistracijosPozymiai.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosPozymiai.Repositories
{
    public class OrdersRepository
    {
        private DataContext _context;
        public OrdersRepository(DataContext context)
        {
            _context = context;
        }

    }
}
