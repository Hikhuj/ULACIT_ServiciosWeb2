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
    
    public partial class Bitacora
    {
        public int Cod_Bitacora { get; set; }
        public int Cod_Usuario { get; set; }
        public System.DateTime Fecha_Hora { get; set; }
        public string Descripcion { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
