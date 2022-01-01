using System.Collections.Generic;

namespace RegistracijosPozymiai.Models
{
    public class FormedRegistration
    {
        public int Id { get; set; }
        public List<ValueRegistration> ValueRegistrations { get; set; }
    }
}
