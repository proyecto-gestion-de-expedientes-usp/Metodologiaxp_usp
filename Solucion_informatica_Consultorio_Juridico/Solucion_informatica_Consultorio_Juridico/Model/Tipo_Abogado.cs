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
    
    public partial class Tipo_Abogado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_Abogado()
        {
            this.Abogado = new HashSet<Abogado>();
        }
    
        public int tipb_id { get; set; }
        public string tipb_def_inc { get; set; }
        public string tipb_estado { get; set; }
        public string tipb_descripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abogado> Abogado { get; set; }
    }
}