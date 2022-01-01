using RegistracijosPozymiai.Models;
using System.Collections.Generic;

namespace RegistracijosPozymiai.Dtos.Registrations
{
    public class Registration
    {
        public int RegistrationId { get; set; }
        public List<RegAttribute> Attributes { get; set; }
        public List<int> AttributesIds { get; set; } = new List<int>();
        public List<RegValue> AttributesSelectedValues { get; set; } = new List<RegValue>();
        public List<int> SelectedValuesIds { get; set; } = new List<int>();
    }
}
