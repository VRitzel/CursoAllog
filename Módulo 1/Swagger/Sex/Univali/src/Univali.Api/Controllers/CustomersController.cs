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

    [HttpGet("{id:int:min(1)}")]
    public ActionResult<Customer> GetCustomer (int id){
        var customer = Data.getInstance.Customers.FirstOrDefault(c => c.Id == id);

        return customer != null ? Ok(customer) : NotFound();
    }

    [HttpGet("cpf/{cpf}")]
    public ActionResult<Customer> GetCustomer (string cpf){
        var customer = Data.getInstance.Customers.FirstOrDefault(c => c.CPF == cpf);

        return customer != null ? Ok(customer) : NotFound();
    }

    [HttpPost]
    public ActionResult<Customer> CreateCustomer(Customer customer){
        var newCustomer = new Customer{
            Id = Data.getInstance.Customers.Max(c => c.Id) + 1,
            Name = customer.Name,
            Cpf = customer.CPF
        };
        
        Data.getInstance.Customers.Add(newCustomer);
        return CreatedAtRoute(
            "GetCustomer",
            new (id= newCustomer.Id),
            newCustomer
        );
    }

}