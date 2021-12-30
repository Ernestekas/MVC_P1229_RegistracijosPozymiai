using RegistracijosPozymiai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosPozymiai.Dtos.Registrations
{
    public class Registration
    {
        public List<RegAttribute> Attributes { get; set; }
        public List<int> AttributesIds { get; set; } = new List<int>();
        public List<RegValue> AttributesSelectedValues { get; set; } = new List<RegValue>();
        public List<int> SelectedValuesIds { get; set; } = new List<int>();
    }
}
