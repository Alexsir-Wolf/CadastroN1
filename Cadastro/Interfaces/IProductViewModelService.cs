using Cadastro.ViewModels;
using System.Collections.Generic;

namespace Cadastro.Interfaces
{
	public interface IProductViewModelService
	{
		ProductViewModel Get(int id);
		IEnumerable<ProductViewModel> GetAll();
		void Insert(ProductViewModel viewModel);
		void Update(ProductViewModel viewModel);
		void Delete(int id);
	}
}
