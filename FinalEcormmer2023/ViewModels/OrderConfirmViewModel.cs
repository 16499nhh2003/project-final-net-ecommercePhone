using System.ComponentModel.DataAnnotations;

namespace FinalEcormer2023.ViewModels {
    public class OrderConfirmViewModel {
        [Required(ErrorMessage = "Please enter your Name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your Username!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your Email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Address!")]
        public string Address { get; set; }
    }
}
