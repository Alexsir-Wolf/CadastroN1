using Cadastro.Domain.Entities;
using System.Collections.Generic;

namespace Cadastro.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Category Get(int id);
        IEnumerable<Category> GetAll();
    }
}
