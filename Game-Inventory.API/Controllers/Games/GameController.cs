using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Game_Inventory.API.Controllers.Games;


[ApiController]
public class GameController : ControllerBase
{

    public GameController()
    {
        
    }

    [HttpGet]
    [Route("/games")]
    [SwaggerOperation(Tags = ["Games"])]
    public IActionResult GetGames()
    {
        throw new NotImplementedException();
    }


    [HttpPost]
    [Route("/games")]
    [SwaggerOperation(Tags = ["Games"])]
    public IActionResult CreateGame([FromBody] string name)
    {
        throw new NotImplementedException();
    }


    [HttpGet]
    [Route("/games/{id}")]
    [SwaggerOperation(Tags = ["Games"])]
    public IActionResult GetGameById([FromRoute] int id)
    {
        throw new NotImplementedException();
    }


    [HttpPut]
    [Route("/games/{id}")]
    [SwaggerOperation(Tags = ["Games"])]
    public IActionResult UpdateGame([FromRoute] int id, [FromBody] string body)
    {
        throw new NotImplementedException();
    }


    [HttpDelete]
    [Route("/games")]
    [SwaggerOperation(Tags = ["Games"])]
    public IActionResult GetGames([FromBody] int id)
    {
        throw new NotImplementedException();
    }
}
