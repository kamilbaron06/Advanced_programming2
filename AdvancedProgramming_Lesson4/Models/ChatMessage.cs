using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson4.Models
{
    public class ChatMessage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required(ErrorMessageResourceType = (typeof(AdvancedProgramming_Lesson4.Resources.Resource)), ErrorMessageResourceName = "Required")]
        [Display(ResourceType = (typeof(AdvancedProgramming_Lesson4.Resources.Resource)), Name = "User")]
        public string User { get; set; }
        [Required(ErrorMessageResourceType = (typeof(AdvancedProgramming_Lesson4.Resources.Resource)), ErrorMessageResourceName = "Required")]
        [Display(ResourceType = (typeof(AdvancedProgramming_Lesson4.Resources.Resource)), Name = "Message")]
        public string Message { get; set; }
        public bool Logged { get; set; }
    }
}
