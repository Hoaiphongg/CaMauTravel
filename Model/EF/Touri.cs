namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Touri
    {
        public long ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [Column(TypeName = "xml")]
        public string MoreImage { get; set; }

        public decimal? Price { get; set; }

        public int? PlaceTypeID { get; set; }

        [StringLength(4000)]
        public string Schedule { get; set; }

        public decimal? PromotionPrice { get; set; }

        public int? Quanlity { get; set; }

        public long? TourisDetailID { get; set; }

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

        public bool Status { get; set; }

        public DateTime? TopHot { get; set; }

        public virtual PlaceType PlaceType { get; set; }

        public virtual TourisAttrDetail TourisAttrDetail { get; set; }
    }
}
