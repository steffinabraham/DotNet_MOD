using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Models
{
    [Table("Training")]
    public class Training
    {
        [Key]
        public long TrainingId { get; set; }


        public long UserId{ get; set; }

        public long MentorId { get; set; }

    
        public long SkillId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [StringLength(20)]
        public string TimeSlot { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        public long Progress { get; set; }

        public int Rating { get; set; }

    }
}
