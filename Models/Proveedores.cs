using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_ActionLink_DiplomadoUASD.Models
{
    public class Proveedores
    {
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
    }
}