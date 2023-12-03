using FinalEcormer2023.Data;
using FinalEcormer2023.Models;
using FinalEcormer2023.ViewModels;
using MessagePack.Formatters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Globalization;
using System.Text.Json.Nodes;

namespace FinalEcormer2023.Controllers {
    public class RevenueController : Controller {
        private readonly ApplicationDbContext _context;
        public RevenueController(ApplicationDbContext applicationDb) {
            _context = applicationDb;
        }
        static List<DateTime> GetDaysInMonth(int year, int month) {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
                             .Select(day => new DateTime(year, month, day))
                             .ToList();
        }

        public IActionResult Revenue() {
            return View("~/Views/Admin/Revenue.cshtml");  
        }
       

        [HttpGet]
        public async Task<IActionResult> Month(String? month="2023-11") {

            DateTime yearMonth = DateTime.ParseExact(month, "yyyy-MM", CultureInfo.InvariantCulture);       
            List<DateTime> localDates = GetDaysInMonth(yearMonth.Year, yearMonth.Month);
            List<RevenueViewModel> revenueMonthDTOS = new List<RevenueViewModel>();

            foreach (DateTime localDate in localDates) {
                RevenueViewModel revenueMonthDTO = new RevenueViewModel();
                revenueMonthDTO.Date = localDate;

                List<Order> orders = await _context.Orders.Where(order => order.OrderDate == localDate).ToListAsync();
                decimal total = orders.Sum(order => order.Total);
                revenueMonthDTO.Total = total;

                revenueMonthDTOS.Add(revenueMonthDTO);
            }

            return Ok(revenueMonthDTOS);
        }
    }
}
