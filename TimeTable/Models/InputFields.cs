using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TimeTable.Models
{


    public class InputFields
    {
        public int Sub_Working_Hours { get; set; } 

        public int Id { get; set; }

        [Required(ErrorMessage = "No of Working days is required")]
        [Range(1, 7, ErrorMessage = "No of Working days must be a positive number between 1 and 7")]
        public int No_of_Working_days { get; set; }

        [Required(ErrorMessage = "No of Subjects per day is required")]
        [Range(1, 8, ErrorMessage = "No of Subjects per day must be a positive number less than 9")]
        public int No_of_Subjects_per_day { get; set; }

        [Required(ErrorMessage = "Total Subjects is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Total Subjects must be a positive number")]
        public int Total_Subjects { get; set; }

        public int Total_hours_for_week { get; set; }

    }

}
