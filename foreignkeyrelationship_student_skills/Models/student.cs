using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foreignkeyrelationship_student_skills.Models
{
    public class student
    {
        [Key]
        public int id { get; set; }
        public string studentname { get; set; }
        public string studentphone { get; set; }
        public int skillid { get; set; }
        [ForeignKey("skillid")]
        public virtual skill Skill { get; set; }
    }
}
