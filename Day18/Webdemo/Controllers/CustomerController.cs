using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/[controller]")]
public class CustomerController : ControllerBase
{
  private readonly ICustomerService customerService;

  
  public CustomerController(ICustomerService customerService)
  {
    this.customerService = customerService;
  }

  [HttpGet]
  public IActionResult Get()
  {
    var customers = customerService.GetAllCustomers();
    return Ok(customers);
  }
}