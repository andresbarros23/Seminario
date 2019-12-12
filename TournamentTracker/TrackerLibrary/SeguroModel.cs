using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SeguroModel
    {
        public int Id { get; set; }
        public TipoSeguroModel Tipo { get; set; }
        public EstadoSeguroModel Estado { get; set; }
        public CompañiaModel Compañia { get; set; }
        public AseguradoModel Asegurado { get; set; }
        public ProductorModel Productor { get; set; }
        public List<DetalleSeguroModel> Detalle { get; set; } = new List<DetalleSeguroModel>();
    }
}
