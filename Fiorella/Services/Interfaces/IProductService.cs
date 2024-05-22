using System;
using Fiorella.Models;

namespace Fiorella.Services.Interfaces
{
	public interface IProductService
	{
		Task<IEnumerable<Product>> GetAllAsync();
		Task<Product> GetByIdWithAllDatas(int id);
		Task<Product> GetByIdAsync(int id);
	}
}

