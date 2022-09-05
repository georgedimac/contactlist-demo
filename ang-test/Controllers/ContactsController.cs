using Microsoft.AspNetCore.Mvc;

namespace ang_test.Controllers;

[ApiController]
[Route("[controller]")]
public class contactsController : ControllerBase
{
    
    [HttpGet]
    public IEnumerable<Contact> Get()
    {
        return Contacts.ContactList;
    }
}
