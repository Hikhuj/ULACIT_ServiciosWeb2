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
    
    public partial class Consecutivos
    {
        public int Cod_Consecutivo { get; set; }
        public Nullable<int> Tipo { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public bool Posee_Prefijo { get; set; }
        public string Prefijo { get; set; }
    
        public virtual Tipo_Consecutivo Tipo_Consecutivo { get; set; }
    }
}
