namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("About")]
    public partial class About
    {
        public long ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(100)]
        public string MetaTitle { get; set; }

        public long? ParentID { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(250)]
        public string SeoTitle { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(250)]
        public string MetaWords { get; set; }

        [StringLength(250)]
        public string MetaDescription { get; set; }

        public bool? Status { get; set; }
    }
}
