using System.ComponentModel.DataAnnotations;

namespace SnapSkill.Web.Areas.Admin.Models
{
    public class Course
    {
        public Guid Id { get; set; }

        
        public string Name { get; set; }

        public string level { get; set; }

        [MaxLength(200,ErrorMessage ="Description Must be less then 100 word")]
        public string Description { get; set; }

        public int Price { get; set; }

        public DateTime startDate { get; set; }

        public TimeSpan RemainingTime
        {
            get
            {
                return startDate - DateTime.UtcNow;
            }
            set
            {
                RemainingTime = value;
            }
        }

        public string DayOfWeek { get; set; }

        public string startTime;

        public string endTime;

    }
}
