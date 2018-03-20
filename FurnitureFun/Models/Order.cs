using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FurnitureFun.Models
{
    public class Order
    {
        

        public int OrderId { get; set; }

        [Required(ErrorMessage = "Please enter your first name.")]
        [Display(Name = "First Name")]
        [MaxLength(100, ErrorMessage = "Please do not exceed 100 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name.")]
        [Display(Name = "Last Name")]
        [MaxLength(100, ErrorMessage = "Please do not exceed 100 characters.")]
        public string LastName { get; set; }


        [Required(ErrorMessage ="Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your street address.")]
        public string Street { get; set; }

        public string StreetLine2 { get; set; }

        [Required(ErrorMessage = "Please enter your city.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your state.")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your zipcode.")]
        [MinLength(5, ErrorMessage = "Please enter your five digit zip code.")]
        [MaxLength(5, ErrorMessage = "Please enter your five digit zip code.")]
        
        public string Zip { get; set; }


        [Required(ErrorMessage = "Please enter a valid phone number.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Please enter your phone number with numbers only. Do not include dashes or spaces")]
        //[Phone(ErrorMessage = "Please enter a valid phone number.")]  <-- StackOverflow indicates this isnt working properly at the time of this publshing, replacing with a regEx
        public string Phone { get; set; }

        public bool IsCompleted { get; set; }

        // Furniture pieces can be associated with more than one order
        public virtual Furniture Furniture { get; set; }
    }
}