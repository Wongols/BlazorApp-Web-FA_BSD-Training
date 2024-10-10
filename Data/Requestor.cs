using System;
using System.Collections.Generic;

namespace BlazorApp_FA_BSD_Training.Data
{
    public partial class Requestor
    {
        public Requestor()
        {
            Incidents = new HashSet<Incident>();
        }

        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Team { get; set; }

        public virtual ICollection<Incident> Incidents { get; set; }
    }
}
