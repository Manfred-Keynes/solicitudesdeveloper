using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace solicitudescooitza.Models.Dtos
{
    public class TblSolicitudesVM
    {
        public long? idTblSolicitudesCatRubros { get; set; }
        public long? idTblSolicitudes { get; set; }
        public string Proveedor { get; set; }
        public string Rubro { get; set; }
        public string Detalle { get; set; }
        public string Monto { get; set; }
        public string Fecha { get; set; }
        public Nullable<long> Cantidad { get; set; }
        public string Imagen { get; set; }
    }
}