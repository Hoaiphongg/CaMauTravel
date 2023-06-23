namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using PagedList;

    [Table("Oder")]
    public partial class Oder
    {
        public long ID { get; set; }

        public long? CustomerID { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(200)]
        public string ShipName { get; set; }

        [StringLength(10)]
        public string Mobile { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        public bool Status { get; set; }
    }
}
