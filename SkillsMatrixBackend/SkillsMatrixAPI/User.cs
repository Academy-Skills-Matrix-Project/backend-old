using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SkillsMatrixAPI
{
    public class User
    {
        [Required(ErrorMessage = "An Email address is required")]
        [EmailAddress]
        [StringLength(30)]
        public string Email { get; set; }

        public string FullName { get; set; }

        public int PhoneNumber { get; set; }
    }
}
