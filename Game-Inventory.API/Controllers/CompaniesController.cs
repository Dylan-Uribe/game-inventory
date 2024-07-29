using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Runtime.InteropServices;

namespace Game_Inventory.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CompaniesController : ControllerBase
{
    [HttpGet]
    [Route("/Companies")]
    [SwaggerOperation(Tags = ["Companies"])]
    public IActionResult GetCompanies()
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("/Companies/{id}")]
    [SwaggerOperation(Tags = ["Companies"])]
    public IActionResult GetCompaniesById([FromRoute] int id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    [Route("/Companies")]
    [SwaggerOperation(Tags = ["Companies"])]
    public IActionResult CreateCompanies([FromBody] string name)
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    [Route("/Companies")]
    [SwaggerOperation(Tags = ["Companies"])]
    public IActionResult DeleteCompanies([FromBody] string name)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("/Companies/{id}")]
    [SwaggerOperation(Tags = ["Companies"])]
    public IActionResult UpdateCompanies([FromRoute] int id, [FromBody] string body)
    {
        throw new NotImplementedException();
    }
}
