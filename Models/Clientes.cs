//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clientes()
        {
            this.Facturas = new HashSet<Facturas>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public string NumeroTarjeta { get; set; }
        public System.DateTime FechaExpiracion { get; set; }
        public string CodigoSeguridad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas> Facturas { get; set; }
    }
}
