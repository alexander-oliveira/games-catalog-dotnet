
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GamesCatalogAPI.InputModels;
using GamesCatalogAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GamesCatalogAPI.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<ActionResult<List<GameViewModel>>> Get([FromQuery, Range(1, int.MaxValue)] int page = 1, [FromQuery, Range(1, 50)] int amount = 5)
        {
            var games = await _gameService.Get(page, amount);
            if (games.Count() == 0)
                return NoContent();
            return Ok(games);
        }
        [HttpGet("{gameId:guid}")]
        public async Task<ActionResult<GameViewModel>> Get([FromRoute] Guid gameId)
        {
            var game = await _gameService.Get(gameId);
            if(game == null)
                return NoContent();
            return Ok(game);
        }
        [HttpPost]
        public async Task<ActionResult<GameViewModel>> Insert( [FromBody] GameInputModel gameInputModel)
        {
            try
            {
                var game = await _gameService.Insert(gameInputModel);
                return Ok(game);
            }
            catch (System.Exception)
            {
                return UnprocessableEntity("There is already a game stored upon this name given the same producer.");
            }
        }
        [HttpPut("{gameId:guid}")]
        public async Task<ActionResult> Update( [FromRoute] Guid gameId, [FromBody] GameInputModel gameInputModel)
        {
            try
            {
                await _gameService.Update(gameId, gameInputModel);
                return Ok();
            }
            catch (System.Exception)
            {
                return NotFound("Game was not found.");   
            }
        }
        [HttpPatch("{gameId:guid}/price/{price:double}")]
        public async Task<ActionResult> Update([FromRoute] Guid gameId, [FromRoute] Double price)
        {
            try
            {
                await _gameService.Update(gameId, price);
                return Ok();
            }
            catch (System.Exception)
            {
                return NotFound("Game was not found");
            }
        }
        [HttpDelete("{gameId:guid}")]
        public async Task<ActionResult> Remove([FromRoute] Guid gameId)
        {
            try
            {
                await _gameService.Remove(gameId);
                return Ok();
            }
            catch (System.Exception)
            {
                return NotFound("Game was not found.");   
            }
        }
    }
}