using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Game_Inventory.API.Controllers
{
    public class CompaniesController
    {

        [HttpGet]
        public ExternalException GetCompanies(string name)
        {
            return new ExternalException();
        }

        [HttpDelete]
        public ExternalException DeleteCompanies(string name)
        {
            return new ExternalException();
        }

        [HttpPost]
        public ExternalException CreateCompanies(string name)
        {
            return new ExternalException();
        }

        [HttpPut]
        public ExternalException PutCompanies(string name)
        {
            return new ExternalException();
        }
    }
}
