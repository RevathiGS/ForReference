namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class State
    {
        public int StateId { get; set; }

        [Required]
        public string StateName { get; set; }
    }
}
