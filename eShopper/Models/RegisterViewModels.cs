using System.ComponentModel.DataAnnotations;

namespace eShopper.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Street")]
        public string BillingAddressStreet { get; set; }

        [Required]
        [Display(Name = "City")]
        public string BillingAddressCity { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string BillingAddressCountry { get; set; }

        [Required]
        [Display(Name = "State")]
        public string BillingAddressState { get; set; }

        [Required]
        [Display(Name = "Street")]
        public string ShippingAddressStreet { get; set; }

        [Required]
        [Display(Name = "City")]
        public string ShippingAddressCity { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string ShippingAddressCountry { get; set; }

        [Required]
        [Display(Name = "State")]
        public string ShippingAddressState { get; set; }

        [Display(Name = "Same as Billing Address")]
        public bool SameAsBilling { get; set; }
    }
}
