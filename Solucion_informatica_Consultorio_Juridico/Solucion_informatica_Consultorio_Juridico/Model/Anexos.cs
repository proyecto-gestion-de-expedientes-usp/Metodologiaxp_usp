//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Solucion_informatica_Consultorio_Juridico.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Anexos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Anexos()
        {
            this.Movimiento_Expediente = new HashSet<Movimiento_Expediente>();
        }
    
        public int anexo_id { get; set; }
        public string anexo_nombre { get; set; }
        public string anexo_nombrereal { get; set; }
        public byte[] anexo_documento { get; set; }
        public Nullable<System.DateTime> anexo_fecha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimiento_Expediente> Movimiento_Expediente { get; set; }
    }
}
