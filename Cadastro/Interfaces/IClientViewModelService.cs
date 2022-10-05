using Cadastro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Interfaces
{
    public interface IClientViewModelService
    {
        ClientViewModel Get(int id);
        IEnumerable<ClientViewModel> GetAll();
        void Insert(ClientViewModel viewModel);
        void Update(ClientViewModel viewModel);
        void Delete(int id);
    }
}
