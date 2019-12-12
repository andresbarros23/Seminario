using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class CompañiaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ApiUrlModel Api { get; set; }
    }
}
