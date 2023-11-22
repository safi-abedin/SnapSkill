using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SnapSkill.Web.Areas.Admin.Models
{
    public class Course : ICourse
    {
        public Guid Id { get; set; }

        
        public string Name { get; set; }

        public string level { get; set; }

        [MaxLength(200,ErrorMessage ="Description Must be less then 100 word")]
        public string Description { get; set; }

        public int Price { get; set; }

        public DateTime startDate { get; set; }

        [NotMapped]
        public DateOnly DateOnly { get; set; }

        public string DayOfWeek { get; set; }

        [Required]
        public string startTime { get; set; }

        public string endTime { get; set; }


        public string ImageURL { get; set; }

        public Course() 
        {

            DateOnly = SeparateTime();
        }

        public DateOnly SeparateTime()
        {
            DateOnly = DateOnly.FromDateTime(startDate);

            return DateOnly;
        }

    }
}
