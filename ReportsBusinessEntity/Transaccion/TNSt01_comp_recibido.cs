namespace ReportsBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TNSt01_comp_recibido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TNSt01_comp_recibido()
        {
            TNSt02_comp_recibido_dtl = new HashSet<TNSt02_comp_recibido_dtl>();
            TNSt03_comp_recibido_estado = new HashSet<TNSt03_comp_recibido_estado>();
        }

        [Key]
        public long id_comp_recibido { get; set; }

        [Required]
        [StringLength(50)]
        public string nro_comp_recibido { get; set; }

        public int id_tipo_comp { get; set; }

        [StringLength(6)]
        public string txt_serie { get; set; }

        [StringLength(14)]
        public string txt_numero { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime fec_reg_recibido { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime fec_emi { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fec_vcto { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fec_canc { get; set; }

        public int id_tipo_moneda { get; set; }

        public int? id_tipo_orden { get; set; }

        public decimal por_impto { get; set; }

        [StringLength(500)]
        public string txt_observ { get; set; }

        public decimal mto_tc_vta { get; set; }

        public decimal mto_neto { get; set; }

        public decimal mto_exonerado { get; set; }

        public decimal mto_no_afecto { get; set; }

        public decimal mto_dscto_tot { get; set; }

        public decimal mto_cms_tot { get; set; }

        public decimal mto_flete_tot { get; set; }

        public decimal mto_sub_tot { get; set; }

        public decimal mto_impto_tot { get; set; }

        public decimal mto_servicio { get; set; }

        public decimal mto_tot_comp { get; set; }

        [StringLength(10)]
        public string ref_tipo_comprobante { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ref_fecha { get; set; }

        [StringLength(6)]
        public string ref_serie { get; set; }

        [StringLength(14)]
        public string ref_numero { get; set; }

        public int? sn_credito { get; set; }

        public int? sn_cancelada { get; set; }

        public long? id_usuario { get; set; }

        [StringLength(50)]
        public string txt_usuario { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fecha_modificacion { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public long? id_proveedor { get; set; }

        public int id_impuesto { get; set; }

        public virtual MSTt03_tipo_orden MSTt03_tipo_orden { get; set; }

        public virtual MSTt06_impuesto MSTt06_impuesto { get; set; }

        public virtual PERt01_usuario PERt01_usuario { get; set; }

        public virtual PERt03_proveedor PERt03_proveedor { get; set; }

        public virtual SNTt04_tipo_moneda SNTt04_tipo_moneda { get; set; }

        public virtual SNTt10_tipo_comprobante SNTt10_tipo_comprobante { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt02_comp_recibido_dtl> TNSt02_comp_recibido_dtl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt03_comp_recibido_estado> TNSt03_comp_recibido_estado { get; set; }
    }
}
