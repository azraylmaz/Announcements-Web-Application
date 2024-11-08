using System.ComponentModel.DataAnnotations;

namespace HwWebApplication.Models{
    public class Announcement{

        public int? Id{get; set;}

        [Required(ErrorMessage ="Title field is required!")]
        public string? Title{get; set;}

        [Required(ErrorMessage ="Text field is required!")]
        public string? Text{get; set;}

        [Required(ErrorMessage ="Responsible Person field is required!")]
        public string? ResponsiblePerson{get; set;}

        public DateTime date{get; set;}  = DateTime.Now;

    }
}