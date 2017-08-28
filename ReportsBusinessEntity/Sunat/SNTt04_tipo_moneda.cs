namespace ReportsBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SNTt04_tipo_moneda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNTt04_tipo_moneda()
        {
            PROt09_producto = new HashSet<PROt09_producto>();
            TNSt01_comp_recibido = new HashSet<TNSt01_comp_recibido>();
            TNSt04_comp_emitido = new HashSet<TNSt04_comp_emitido>();
        }

        [Key]
        public int id_tipo_moneda { get; set; }

        [StringLength(10)]
        public string cod_tipo_moneda { get; set; }

        [StringLength(10)]
        public string cod_tipo_moneda_ple { get; set; }

        [StringLength(150)]
        public string txt_abrv { get; set; }

        public decimal? dec_cambio { get; set; }

        [StringLength(250)]
        public string txt_desc { get; set; }

        [StringLength(100)]
        public string txt_pais { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt09_producto> PROt09_producto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt01_comp_recibido> TNSt01_comp_recibido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt04_comp_emitido> TNSt04_comp_emitido { get; set; }
    }
}
