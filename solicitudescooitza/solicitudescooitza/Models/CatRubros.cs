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
    
    public partial class CatRubros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatRubros()
        {
            this.TblSolicitudes = new HashSet<TblSolicitudes>();
            this.TblSolicitudes1 = new HashSet<TblSolicitudes>();
            this.TblSolicitudesCatRubros = new HashSet<TblSolicitudesCatRubros>();
        }
    
        public long idCatRubros { get; set; }
        public string descripcion { get; set; }
        public Nullable<long> idTblUsuarioAlta { get; set; }
        public Nullable<System.DateTime> fechaAlta { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<long> idTblUsuarioModificacion { get; set; }
        public Nullable<long> idCatEstados { get; set; }
    
        public virtual CatEstados CatEstados { get; set; }
        public virtual TblUsuarios TblUsuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSolicitudes> TblSolicitudes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSolicitudes> TblSolicitudes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSolicitudesCatRubros> TblSolicitudesCatRubros { get; set; }
    }
}