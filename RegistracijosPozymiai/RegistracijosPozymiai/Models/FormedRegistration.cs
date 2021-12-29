using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosPozymiai.Models
{
    public class FormedRegistration
    {
        public int RegAttributeId { get; set; }
        public RegAttribute RegAttribute { get; set; }
        public int RegValueId { get; set; }
        public RegValue RegValue { get; set; }
    }
}
