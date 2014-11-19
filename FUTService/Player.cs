namespace FUTService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Player")]
    public partial class Player
    {
        public int PlayerId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime Age { get; set; }

        public int? KitNumber { get; set; }

        [Required]
        [StringLength(3)]
        public string Position { get; set; }

        public int? ClubId { get; set; }

        public virtual Club Club { get; set; }
    }
}
