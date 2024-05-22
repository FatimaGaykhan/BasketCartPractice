using System;
using Fiorella.Models;
using Fiorella.ViewModels.Categories;

namespace Fiorella.Services.Interfaces
{
	public interface ICategoryService
	{
		Task<IEnumerable<Category>> GetAllAsync();
		Task<IEnumerable<CategoryProductVM>> GetAllWithProductCountAsync();
		Task<Category> GetByIdAsync(int id);
		Task<bool> ExistAsync(string name);
		Task CreateAsync(Category category);
		Task DeleteAsync(Category category);
		Task<Category> DetailAsync(int id);
		Task<bool> ExistExceptByIdAsync(int id, string name);
		Task EditAsync(Category category,string request);
        Task<IEnumerable<CategoryArchiveVM>> GetAllArchiveAsync();

    }
}

