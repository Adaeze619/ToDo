using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class Tasks
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
    }
}
