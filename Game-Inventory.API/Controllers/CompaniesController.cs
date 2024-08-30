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
        var companies = await _context.
            Companies.
            ToListAsync();

        return Ok(companies);
    }

    [HttpGet]
    [Route("/companies/{id}")]
    [SwaggerOperation(Tags = ["Companies"])]
    public  async Task<IActionResult> GetCompaniesById([FromRoute] int id)
    {
        var company = await _context.
            Companies.
            FindAsync(id);

        return company is null
            ? NotFound() 
            : Ok(company);
    }

    [HttpPost]
    [Route("/companies")]
    [SwaggerOperation(Tags = ["Companies"])]
    public async Task<IActionResult> CreateCompanies([FromBody] Company company)
    {
        
        if(company is null)
        {
            return BadRequest("Company can not be null!!!");
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
    [Route("/companies")]
    [SwaggerOperation(Tags = ["Companies"])]
    public IActionResult DeleteCompanies([FromBody] string name)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("/companies/{id}")]
    [SwaggerOperation(Tags = ["Companies"])]
    public async Task<IActionResult> UpdateCompanies([FromRoute] int id, [FromBody] Company company)
    {
        if(id != company.Id)
        {
            return BadRequest(
                "The Id in the URL does not match the id in the request body"
            );
        }

        try
        {

            var companyToUpdate = await _context.Companies.FindAsync(id);

            if(companyToUpdate is null)
                return NotFound();

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
}
