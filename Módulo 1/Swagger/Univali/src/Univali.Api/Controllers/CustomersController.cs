using Microsoft.AspNetCore.Mvc;
using Univali.Api.Entities;
namespace Univali.Api.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomersController : ControllerBase{

    [HttpGet]
    public ActionResult<IEnumerable<Customer>> GetCustomers(){
        
        var result = Data.getInstance().Customers;
        return Ok(result);
    }
}