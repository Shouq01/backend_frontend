using Microsoft.AspNetCore.Mvc;

namespace backendAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class namesController : ControllerBase
{
    //Initiate names list to be used and returned
    namesList[] names = new namesList[]{
         new namesList { name = "Shouq", rule="Product Quality Analyst"},
         new namesList { name = "Abdulrahman", rule="Teacher and Backend Engineer"},
         new namesList { name = "Hana", rule="Developer" },
         new namesList { name = "Afnan", rule="Full stack developer" }


      };


    private readonly ILogger<namesController> _logger;
    public namesController(ILogger<namesController> logger)
    {
        _logger = logger;
    }



    //Get lit method
    [HttpGet(Name = "GetNames")]
    public IEnumerable<namesList> GetAllnames()
    {
        return names;
    }



 
}

