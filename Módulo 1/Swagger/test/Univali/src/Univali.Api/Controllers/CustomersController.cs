using Microsoft.AspNetCore.Mvc;
using Univali.Api.Entities;
using Univali.Api.Models;
namespace Univali.Api.Controllers;
using System;

[ApiController]
[Route("api/customers")]
public class CustomersController : ControllerBase{

    [HttpGet]
    public ActionResult<IEnumerable<CustomerDTO>> GetCustomers(){
        
        var customersToReturn = Data.getInstance.Customers.Select(Customer => new CustomerDTO()
        {
            id = Customer.Id,
            Name = Customer.Name,
            Cpf = Customer.Cpf
        });
        
        return Ok(customersToReturn);
    }

    [HttpGet("{id}", Name = "GetCustomer")]
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