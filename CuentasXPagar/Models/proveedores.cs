//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CuentasXPagar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class proveedores
    {
        public proveedores()
        {
            this.entradadocumentos = new HashSet<entradadocumentos>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoPersona { get; set; }
        public string Cedula { get; set; }
        public double Balance { get; set; }
        public string Estado { get; set; }
    
        public virtual ICollection<entradadocumentos> entradadocumentos { get; set; }
    }
}
