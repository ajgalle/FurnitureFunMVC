using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FurnitureFun.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your first name.")]
        [Display(Name = "First Name")]
        [MaxLength(100, ErrorMessage = "Please do not exceed 100 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name.")]
        [Display(Name = "Last Name")]
        [MaxLength(100, ErrorMessage = "Please do not exceed 100 characters.")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a valid phone number.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Please enter your phone number with numbers only. Do not include dashes or spaces")]
        //[Phone(ErrorMessage = "Please enter a valid phone number.")]  <-- StackOverflow indicates this isnt working properly at the time of this publshing, replacing with a regEx
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please check the box to agree")]
        public bool HasAgreed { get; set; }

        public virtual ICollection<Furniture> Furniture { get; set; }
    }
}