//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laboratorio2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.Detalle_Factura = new HashSet<Detalle_Factura>();
            this.Detalle_Pedido = new HashSet<Detalle_Pedido>();
        }
    
        public int Cod_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public Nullable<int> Cod_Linea { get; set; }
        public Nullable<int> Cod_Proveedor { get; set; }
        public bool Descontinuado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Factura> Detalle_Factura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Pedido> Detalle_Pedido { get; set; }
        public virtual Lineas Lineas { get; set; }
        public virtual Proveedores Proveedores { get; set; }
    }
}
