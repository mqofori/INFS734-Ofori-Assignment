using System;
using System.ComponentModel.DataAnnotations;

namespace INFS734_Ofori_Assignment.Models
{
    public class Task
    {
        [Required(ErrorMessage = "Please  enter the due date")]
        public string DueDate { get; set; }

        [Required(ErrorMessage = "Please  enter the due time")]
        public string DueTime { get; set; }

        [Required(ErrorMessage = "Please enter the task title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the task description")]
        public string Description { get; set; }
    }
}