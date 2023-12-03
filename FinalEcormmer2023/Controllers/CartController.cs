using FinalEcormer2023.Data;
using FinalEcormer2023.Extensions;
using FinalEcormer2023.Interfaces;
using FinalEcormer2023.Models;
using FinalEcormer2023.Sales;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalEcormer2023.Controllers {
	public class CartController : Controller {
		private readonly IProductService _productService;
        private readonly ApplicationDbContext _context;
		private readonly SignInManager<IdentityUser> _signInManager;
		private readonly UserManager<IdentityUser> _userManager;
		public CartController(IProductService productService , ApplicationDbContext applicationDbContext , SignInManager<IdentityUser> signInManager , UserManager<IdentityUser> userManager) {
			_productService = productService;
			_context = applicationDbContext;
			_signInManager = signInManager;
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult Index() {
			var cart = HttpContext.Session.Get<List<CartItem>>("cart");
			if (cart != null) {
				ViewBag.total = cart.Sum(s => s.Quantity * s.Product.Price);
			} else {
				cart = new List<CartItem>();
			}
			return View(cart);
		}

		[HttpGet]
		public async Task<IActionResult> Buy(int id) {

			var product = await _productService.GetById(id);
			var cart = HttpContext.Session.Get<List<CartItem>>("cart");

			if (cart == null) {
				cart = new List<CartItem>();
				CartItem cartItem = new CartItem() { Product = product, Quantity = 1 };
				cart.Add(cartItem);
			}
			else {
				int index = cart.FindIndex(w => w.Product.Id == id);
				if (index != -1) {
					cart[index].Quantity++;
				} 
				else {
					CartItem cartItem = new CartItem() { Product = product, Quantity = 1 };
					cart.Add(cartItem);
				}
			}

			HttpContext.Session.Set<List<CartItem>>("cart" , cart);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public async Task<IActionResult> Add(int id) {
			var product = await _productService.GetById(id);
			var cart = HttpContext.Session.Get<List<CartItem>>("cart");
			int index = cart.FindIndex(x => x.Product.Id == id);
			cart[index].Quantity++;
			HttpContext.Session.Set<List<CartItem>>("cart" , cart) ;
			return RedirectToAction("Index");
		}

		[HttpGet]
		public async Task<IActionResult> Delete(int id) {
			var product = await _productService.GetById(id);
			var cart = HttpContext.Session.Get<List<CartItem>>("cart");
			int index = cart.FindIndex(x => x.Product.Id == id);
			if (cart[index].Quantity == 1) {
				cart.RemoveAt(index);
			} else {
				cart[index].Quantity--;
			}
			HttpContext.Session.Set<List<CartItem>>("cart", cart);
			return RedirectToAction("Index");
		}


		[HttpGet]
		public async Task<IActionResult> Remove(int id) {
			var product = await _productService.GetById(id);
			var cart = HttpContext.Session.Get<List<CartItem>>("cart");
			int index = cart.FindIndex(x => x.Product.Id ==id);
			cart.RemoveAt(index);
			HttpContext.Session.Set<List<CartItem>>("cart", cart);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Checkout() {
            var cart = HttpContext.Session.Get<List<CartItem>>("cart");
            if (cart != null) {
                ViewBag.total = cart.Sum(s => s.Quantity * s.Product.Price);
            } else {
				cart = new List<CartItem>();
            }
			CheckoutViewModel checkoutViewModel = new CheckoutViewModel() {
				cartItems = cart,
				checkoutRequest = new CheckoutRequest(),
			};
			return View(checkoutViewModel);
		}

		[HttpPost]
		public async Task<IActionResult> Checkout(CheckoutRequest request) {

                var user = await _userManager.GetUserAsync(User);

                if (user == null) {
                    return RedirectToAction("Login", "Account");
                }

                var cart = HttpContext.Session.Get<List<CartItem>>("cart");

				if(cart == null) {
                    return RedirectToAction("Index", "Cart");
                }

                decimal total = cart.Sum(s => s.Quantity * s.Product.Price);

                Order order = new Order() {
                    OrderDate = DateTime.Today,
                    Total = total,
                    UserId = user.Id,
                    ShipName = request.Name,
                    ShipEmail = request.Email,
                    ShipAddress = request.Address,
                    ShipPhoneNumber = request.PhoneNumber,
                };

                _context.Orders.Add(order);
                _context.SaveChanges();

                List<OrderDetail> OrderDetail = new List<OrderDetail>();
                foreach (var item in cart) {
                    OrderDetail.Add(new OrderDetail {
                        Quantity = item.Quantity,
                        OrderId = order.Id,
                        ProductId = item.Product.Id,
                    });
                }

                _context.OrderDetails.AddRange(OrderDetail);
                _context.SaveChanges();

                OrderInfoModelView orderInfoModelView = new OrderInfoModelView() {
                    order = order,
                    orderDetail = _context.OrderDetails.Include(_p => _p.Product).Where(p => p.OrderId == order.Id).ToList(),
                };

                HttpContext.Session.Set<List<CartItem>>("cart", null);
                return View("Confirmation", orderInfoModelView);
              
		}

		[HttpGet]
		public IActionResult Count() {
			var cart =	HttpContext.Session.Get<List<CartItem>>("cart");
			if (cart == null) {
				return Json(new { code = 0, data = 0 });
			}
			return Json(new {code = 1 , data = cart.Count});	
		}

	}
	
}
