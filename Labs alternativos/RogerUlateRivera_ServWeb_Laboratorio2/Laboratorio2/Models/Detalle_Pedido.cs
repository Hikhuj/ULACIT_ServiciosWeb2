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
    
    public partial class Detalle_Pedido
    {
        public int Cod_Detalle_Pedido { get; set; }
        public Nullable<int> Num_Pedido { get; set; }
        public Nullable<int> Cod_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    
        public virtual Pedidos Pedidos { get; set; }
        public virtual Productos Productos { get; set; }
    }
}
