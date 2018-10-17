namespace AdaptiveUI.Libraries
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Work
    {
        public int WorkID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
