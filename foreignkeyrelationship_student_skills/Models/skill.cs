using System.ComponentModel.DataAnnotations;

namespace foreignkeyrelationship_student_skills.Models
{
    public class skill
    {
        [Key]
        public int id { get; set; }
        public string skillname { get; set; }
    }
}
