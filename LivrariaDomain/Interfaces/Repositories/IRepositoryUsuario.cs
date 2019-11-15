using LivrariaDomain.Entities;
using LivrariaDomain.Interfaces.Repositories.Base;
using System;

namespace LivrariaDomain.Interfaces.Repositories
{
    public interface IRepositoryUsuario : IRepositoryBase<Usuario, Guid>
    {
    }
}
