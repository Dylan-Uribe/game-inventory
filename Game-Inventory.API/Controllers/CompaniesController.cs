using Game_Inventory.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using System.Runtime.InteropServices;

namespace Game_Inventory.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CompaniesController : ControllerBase
{

    private readonly GameStopContext _context;

    public CompaniesController(GameStopContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("/companies")]
    [SwaggerOperation(Tags = ["Companies"])]
    public async Task<IActionResult> GetCompanies()
    {

        try
        {
            var companies = await _context
                .Companies
                .ToListAsync();

            return Ok(companies);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An error ocurred: {ex.Message}");
        }
    }

    [HttpGet]
    [Route("/companies/{id}")]
    [SwaggerOperation(Tags = ["Companies"])]
    public  async Task<IActionResult> GetCompaniesById([FromRoute] int id)
    {
        var company = await _context
            .Companies
            .FindAsync(id);  

        if(company is null)
        {
            var problemDetails = new ProblemDetails()
            {
                Status = 404,
                Title = "Company not found",
                Detail = $"Company with Id '{id}' was not found."
            };

            return NotFound(problemDetails);
        }

        return Ok(company);

        /*return company is null
            ? NotFound() 
            : Ok(company);*/
    }

    [HttpPost]
    [Route("/companies")]
    [SwaggerOperation(Tags = ["Companies"])]
    public async Task<IActionResult> CreateCompanies([FromBody] Company company)
    {
        
        if(company is null)
        {
            var problemDetails = new ProblemDetails()
            {
                Status = 400,
                Title = "Invalid input",
                Detail = "The request Body is missing required fields or " +
                         "the provided data is incorrectly formatted. "
            };
            return BadRequest(problemDetails);
        }

        try
        {
            _context.Companies.Add(company);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An error ocurred: {ex.Message}");
        }

        return CreatedAtAction(
           nameof(GetCompanies),
           new { id = company.Id },
           company
        );

    }

    [HttpDelete]
    [Route("/companies/{id}")]
    [SwaggerOperation(Tags = ["Companies"])]
    public async Task<IActionResult> DeleteCompanies([FromRoute] int id)
    {
        var company = await _context
            .Companies
            .FindAsync(id);

        if(company is null)
        {
            var problemDdetails = new ProblemDetails
            {
                Status = 404,
                Title = "Company not found",
                Detail = $"Company with id '{id}' was not found.",
            };
            return NotFound(problemDdetails);
        }

        try
        {
            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        catch(Exception ex)
        {
            return StatusCode(500, $"An error ocurred: {ex.Message}");
        }

    }

    [HttpPut]
    [Route("/companies/{id}")]
    [SwaggerOperation(Tags = ["Companies"])]
    public async Task<IActionResult> UpdateCompanies([FromRoute] int id, [FromBody] Company company)
    {

        if(company is null)
        {
            var problemDetails = new ProblemDetails
            {
                Status = 400,
                Title = "Invalid Input",
                Detail = "Invalid input: The request body is missing required fields or " +
                         "the provided data is incorrectly formatted.",
            };
            return BadRequest(problemDetails);
        }

        if(id != company.Id)
        {
            var problemDetails = new ProblemDetails
            {
                Status = 400,
                Title = "Id Mismatch",
                Detail = "The Id in the URL does not match the id in the request body.",
            };
            return BadRequest(problemDetails);
        }

        try
        {

            var companyToUpdate = await _context.Companies.FindAsync(id);

            if(companyToUpdate is null)
            {
                var problemDdetails = new ProblemDetails
                {
                    Status = 404,
                    Title = "Company not found",
                    Detail = $"Company with id '{id}' was not found.",
                };
                return NotFound(problemDdetails);
            }

            companyToUpdate.Name = company.Name;
            companyToUpdate.CEO = company.CEO;
            companyToUpdate.Description = company.Description;
            companyToUpdate.State = company.State;


            _context.Companies.Update(companyToUpdate);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex) 
        {
            return StatusCode(500, $"An error ocurred: {ex.Message}");
        }

        return NoContent();
    }

    [HttpGet]
    [Route("/companies")]
    [SwaggerOperation(Tags = ["Companies"])]
    public async Task<IActionResult> GetCompanies2()
    {
      throw new NotImplementedException();
    }

    [HttpPost]
    [Route("/companies")]
    [SwaggerOperation(Tags = ["companies"])]
    public IActionResult CreateGame([FromBody] string name)
    {
        throw new NotImplementedException();
    }
}
