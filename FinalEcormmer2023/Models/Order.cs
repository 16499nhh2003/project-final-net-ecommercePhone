namespace FinalEcormer2023.Models {
	public class Order {
		public int Id { get; set; }
		public DateTime OrderDate { get; set; }
		public decimal Total { get; set; }	
		public string UserId {  get; set; }	
		public string ShipName {  get; set; }	
		public string ShipAddress { get; set; }
		public string ShipEmail {  get; set; }	
		public string ShipPhoneNumber { get; set; }
		public ICollection<OrderDetail>	orderDetails {  get; set; }
		public AppUser? AppUser { get; set; }
	}
}	