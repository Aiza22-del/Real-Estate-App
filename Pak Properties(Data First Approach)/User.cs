namespace CodeFirstApproach
{
	public class User
	{

		public int Id { get; set; }

		public string? Name { get; set; }

		public string? Email { get; set; }

		public string? Password { get; set; }

		public string? BuyerStatus { get; set; }

		public string? SalerStatus { get; set; }

		public string? ContactNo { get; set; }

		public string? City { get; set; }

		public virtual ICollection<Property> Properties { get; set; } = new List<Property>();
	}
}
