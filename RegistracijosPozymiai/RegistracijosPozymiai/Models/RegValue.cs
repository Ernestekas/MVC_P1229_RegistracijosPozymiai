using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosPozymiai.Models
{
    public class RegValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationAttributeId { get; set; }
        public RegAttribute RegistrationAttribute { get; set; }
        public List<ValueRegistration> ValueRegistrations { get; set; }
    }
}
