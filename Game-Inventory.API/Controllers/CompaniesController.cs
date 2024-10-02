using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Runtime.InteropServices;

namespace Game_Inventory.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CompaniesController : ControllerBase
{
    [HttpGet]
    [Route("/companies")]
    [SwaggerOperation(Tags = ["Companies"])]
    public IActionResult GetCompanies()
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("/companies/{id}")]
    [SwaggerOperation(Tags = ["Companies"])]
    public IActionResult GetCompaniesById([FromRoute] int id)
    {
        throw new NotImplementedException();
    }
}
