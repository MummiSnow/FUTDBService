namespace FUTService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Club")]
    public partial class Club
    {
        public Club()
        {
            Players = new HashSet<Player>();
        }

        public int ClubId { get; set; }

        [Required]
        [StringLength(50)]
        public string ClubName { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(50)]
        public string Division { get; set; }

        public int Founded { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
