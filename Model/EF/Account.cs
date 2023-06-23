namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        public int account_id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(200)]
        public string password { get; set; }

        public int roll { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public bool gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime birthday { get; set; }

        [Required]
        [StringLength(100)]
        public string address { get; set; }

        [Required]
        [StringLength(15)]
        public string phone { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public bool status { get; set; }
    }
}
