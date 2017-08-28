namespace ReportsBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SNTt26_modalidad_formativa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNTt26_modalidad_formativa()
        {
            PERt04_empleado = new HashSet<PERt04_empleado>();
        }

        [Key]
        public int id_modalidad_formativa { get; set; }

        [StringLength(10)]
        public string cod_modalidad_formativa { get; set; }

        [StringLength(10)]
        public string cod_modalidad_formativa_ple { get; set; }

        [StringLength(70)]
        public string txt_abrv { get; set; }

        [StringLength(250)]
        public string txt_desc { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERt04_empleado> PERt04_empleado { get; set; }
    }
}
