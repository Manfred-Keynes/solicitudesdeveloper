//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace solicitudescooitza.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblSolicitudesCatRubros
    {
        public long idTblSolicitudesCatRubros { get; set; }
        public Nullable<long> idTblSolicitudes { get; set; }
        public Nullable<long> idCatRubros { get; set; }
        public Nullable<long> idCatProveedores { get; set; }
        public Nullable<long> idCatEstados { get; set; }
        public string detalle { get; set; }
        public Nullable<decimal> monto { get; set; }
        public Nullable<System.DateTime> fechaFactura { get; set; }
        public Nullable<long> cantidad { get; set; }
        public string imagen { get; set; }
        public Nullable<System.DateTime> fechaAlta { get; set; }
        public Nullable<long> idTblUsuarios { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idTblUsuarioModifica { get; set; }
    
        public virtual CatProveedores CatProveedores { get; set; }
        public virtual CatRubros CatRubros { get; set; }
        public virtual TblSolicitudes TblSolicitudes { get; set; }
    }
}
