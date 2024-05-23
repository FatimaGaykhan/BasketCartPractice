using System;
namespace Fiorella.ViewModels.Baskets
{
	public class BasketCartVM
	{
		public int Id { get; set; }
		public decimal Price { get; set; }
		public string ProductName { get; set; }
		public string Image { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
        public int Count { get; set; }


    }
}

