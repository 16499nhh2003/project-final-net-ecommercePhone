using FinalEcormer2023.Models;
using System.ComponentModel.DataAnnotations;

namespace FinalEcormer2023.Sales {
    public class CheckoutRequest {
        [Required(ErrorMessage = "Please enter your Name!")]
        public string Name {  get; set; }
        [Required(ErrorMessage = "Please enter your Email!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your Address!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your PhoneNumber!")]
        public string PhoneNumber { get; set; }
          
        public List<CartItem> orderDetails { get; set; }    
    }
}
