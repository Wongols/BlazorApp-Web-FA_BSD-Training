using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;




namespace BlazorApp_FA_BSD_Training.Models
{
    public class Session
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Session title is required")]
        [StringLength(100, ErrorMessage ="Please keep the title below" +
            " 100 characters")]

  
        public string? Title { get; set; }

        [Required(ErrorMessage = "Session Date is required")]
        public DateTime Date { get; set; }


        [Required(ErrorMessage = "Session Duration is required")]
             public int Duration { get; set; }

        public string? Knowledge_Base { get; set; }
        public string? Link_IT_help_ticket { get; set; }

    }
}



