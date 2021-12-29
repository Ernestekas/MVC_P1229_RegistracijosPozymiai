using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosPozymiai.Models
{
    public class RegAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RegValue> RegistrationValues { get; set; }
    }
}
