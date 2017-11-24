using System.ComponentModel.DataAnnotations;

namespace ERL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your user name")]
        public string UserName { get; set; }
        public string Email { get; set; }
        public Nullable<int> ContactNo { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }
        public string CompanyName { get; set; }
    }
}
