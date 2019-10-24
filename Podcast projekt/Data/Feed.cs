using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Feed : Namn
    {
        public new virtual string name { get; set; }
        public string link { get; set; }
        public decimal frekvens { get; set; }
        public List<Poddar> podCastLista { get; set; }
    }
}
