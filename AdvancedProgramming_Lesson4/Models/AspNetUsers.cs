using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson4.Models
{
    public class AspNetUsers
    {

        public string Id { get; set; }

        [Required(ErrorMessageResourceType = (typeof(AdvancedProgramming_Lesson4.Resources.Resource)), ErrorMessageResourceName = "Required")]
        [Display(ResourceType = (typeof(AdvancedProgramming_Lesson4.Resources.Resource)), Name = "UserName")]
        public string UserName { get; set; }
  
        [Required(ErrorMessageResourceType = (typeof(AdvancedProgramming_Lesson4.Resources.Resource)), ErrorMessageResourceName = "Required")]
        public string Email { get; set; }



    }
}
