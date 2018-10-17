namespace AdaptiveUI.Libraries
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkItem
    {
        [Key]
        public long ItemID { get; set; }

        public int? WorkID { get; set; }

        public long? UserID { get; set; }

        [StringLength(50)]
        public string Title { get; set; }
    }
}
