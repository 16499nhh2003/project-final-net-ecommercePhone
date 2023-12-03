using FinalEcormer2023.Models;
using FinalEcormer2023.ViewModels;

namespace FinalEcormer2023.Sales {
    public class CheckoutViewModel {
        public List<CartItem> cartItems {  get; set; } 
        public CheckoutRequest checkoutRequest { get; set; }    
    }
}
