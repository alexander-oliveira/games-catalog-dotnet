
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GamesCatalogAPI.InputModels;
using GamesCatalogAPI.ViewModels;

public interface IGameService : IDisposable
{
    Task<List<GameViewModel>> Get(int page, int amount);
    Task<GameViewModel> Get(Guid id);
    Task<GameViewModel> Insert(GameInputModel game);
    Task Update(Guid id, GameInputModel game);
    Task Update(Guid id, double price);
    Task Remove(Guid id);
}