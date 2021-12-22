namespace championsleague.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rank")]
    public partial class Rank
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int player_Id { get; set; }

        [StringLength(20)]
        public string Player_name { get; set; }

        [StringLength(20)]
        public string Team_name { get; set; }
    }
}
