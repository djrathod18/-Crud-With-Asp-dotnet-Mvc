namespace championsleague.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Team_Id { get; set; }

        [StringLength(20)]
        public string Team_name { get; set; }

        [StringLength(20)]
        public string League { get; set; }

        [StringLength(20)]
        public string Country { get; set; }
    }
}
