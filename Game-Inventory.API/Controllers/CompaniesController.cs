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

    [HttpPost]
    [Route("/companies")]
    [SwaggerOperation(Tags = ["Companies"])]
    public IActionResult CreateCompanies([FromBody] string name)
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    [Route("/companies")]
    [SwaggerOperation(Tags = ["Companies"])]
    public IActionResult DeleteCompanies([FromBody] string name)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("/companies/{id}")]
    [SwaggerOperation(Tags = ["Companies"])]
    public IActionResult UpdateCompanies([FromRoute] int id, [FromBody] string body)
    {
        throw new NotImplementedException();
    }
}
