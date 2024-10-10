using System;
using System.Collections.Generic;

namespace BlazorApp_FA_BSD_Training.Data
{
    public partial class Incident
    {
        public int Id { get; set; }
        public string? Incidentnumber { get; set; }
        public string? Description { get; set; }
        public string? Comment { get; set; }
        public int? RequestorId { get; set; }

        public virtual Requestor? Requestor { get; set; }
    }
}
