namespace ReportsBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSTt15_estado_mesa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTt15_estado_mesa()
        {
            MSTt14_mesa = new HashSet<MSTt14_mesa>();
        }

        [Key]
        public int id_estado_mesa { get; set; }

        [StringLength(10)]
        public string cod_estado_mesa { get; set; }

        [Required]
        [StringLength(50)]
        public string txt_desc { get; set; }

        [StringLength(7)]
        public string txt_color_hex { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSTt14_mesa> MSTt14_mesa { get; set; }
    }
}
