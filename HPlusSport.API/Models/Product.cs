using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HPlusSport.API.Models
{
	public class Product
	{
		public int Id { get; set; }
		[Required]
		public string Sku { get; set; } = String.Empty;
		[Required]
		public string Name { get; set; } = String.Empty;
		[Required]
		public string Description { get; set; } = String.Empty;
		public decimal Price { get; set; } = 0;
		public bool IsAvailable { get; set; } = false;
		[Required]
		public int CategoryId { get; set; }
		[JsonIgnore]
		public virtual Category? Category { get; set; }
	}
}

