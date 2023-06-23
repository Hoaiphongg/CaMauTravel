namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TourisAttrDetail")]
    public partial class TourisAttrDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TourisAttrDetail()
        {
            Touris = new HashSet<Touri>();
        }

        public long ID { get; set; }

        [StringLength(500)]
        public string SelectTourisAttraction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Touri> Touris { get; set; }

        [NotMapped]
        public IEnumerable<TouristAttraction> DetailCollection { get; set; }

        [NotMapped]
        public string[] SelectedIDArray { get; set; }
    }
}
