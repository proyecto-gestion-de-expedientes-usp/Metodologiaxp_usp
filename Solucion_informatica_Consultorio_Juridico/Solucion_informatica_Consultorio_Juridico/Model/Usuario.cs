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
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Movimiento_Expediente = new HashSet<Movimiento_Expediente>();
        }
    
        public int usu_id { get; set; }
        public int tipusu_id { get; set; }
        public string usu_dni { get; set; }
        public string usu_nombres { get; set; }
        public string usu_apellidopat { get; set; }
        public string usu_apellidomat { get; set; }
        public string usu_telefono { get; set; }
        public string usu_direccion { get; set; }
        public string usu_sexo { get; set; }
        public string usu_correo { get; set; }
        public string usu_estadocivil { get; set; }
        public Nullable<System.DateTime> usu_fechanac { get; set; }
        public string usu_ciudad { get; set; }
        public string usu_provincia { get; set; }
        public int id_estusu { get; set; }
        public string usu_departamento { get; set; }
        public string usu_contraseña { get; set; }
    
        public virtual Estado_Usu Estado_Usu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimiento_Expediente> Movimiento_Expediente { get; set; }
        public virtual Tipo_Usuario Tipo_Usuario { get; set; }
    }
}
