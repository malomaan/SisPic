//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SisPicBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ciudad
    {
        public string ciu_codigo { get; set; }
        public string ciu_nombre { get; set; }
        public Nullable<bool> ciu_capital { get; set; }
        public Nullable<decimal> ciu_latitud { get; set; }
        public Nullable<decimal> ciu_longitud { get; set; }
        public string dep_codigo { get; set; }
    
        public virtual Departamento Departamento { get; set; }
    }
}
