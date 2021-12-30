using RegistracijosPozymiai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosPozymiai.Dtos.Registrations
{
    public class NewRegistration
    {
        public List<RegAttribute> Attributes { get; set; }
        public List<RegValue> AttributesSelectedValues { get; set; } = new List<RegValue>();
        public List<int> SelectedValuesIds { get; set; } = new List<int>();
    }
}
