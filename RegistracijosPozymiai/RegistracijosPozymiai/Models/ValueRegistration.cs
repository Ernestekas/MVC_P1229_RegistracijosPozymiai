using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosPozymiai.Models
{
    public class ValueRegistration
    {
        public int RegValueId { get; set; }
        public RegValue RegValue { get; set; }
        public int FormedRegistrationId { get; set; }
        public FormedRegistration FormedRegistration { get; set; }
    }
}
