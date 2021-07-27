
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GamesCatalogAPI.Entities;

namespace GamesCatalogAPI.Repositories
{
    public interface IGameRepository : IDisposable
    {
        Task<List<Game>> Get (int page, int amount);
        Task<Game> Get (Guid id);
        Task<List<Game>> Get (String name, String producer);
        Task Insert(Game game);
        Task Update(Game game);
        Task Remove(Guid id);
    }
}