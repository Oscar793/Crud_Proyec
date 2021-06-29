using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud_Proyec.Models
{
    public class ReporteCompra
    {
        public String nombrecliente { get; set; }
        public String documentocliente { get; set; }
        public DateTime fechacompra { get; set; }
        public int totalcompra { get; set; }
    }
}