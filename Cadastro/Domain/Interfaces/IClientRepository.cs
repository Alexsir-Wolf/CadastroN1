using Cadastro.Domain.Entities;
using System.Collections.Generic;

namespace Cadastro.Domain.Interfaces
{
    public interface IClientRepository
    {
        Client Get(int id);
        IEnumerable<Client> GetAll();
        void Insert(Client client);
        void Update(Client client);
        void Delete(int id);
    }
}
