using Microsoft.AspNetCore.Mvc;

namespace backendAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class namesController : ControllerBase
{
    //Initiate names list to be used and returned
    namesList[] names = new namesList[]{
         new namesList { name = "Shouq", randomGif="<iframe src=\"https://giphy.com/embed/ICOgUNjpvO0PC\" width=\"480\" height=\"359\" frameBorder=\"0\" class=\"giphy-embed\" allowFullScreen></iframe><p><a href=\"https://giphy.com/gifs/cat-humour-funny-ICOgUNjpvO0PC\">via GIPHY</a></p>" },
         new namesList { name = "Abdulrahman", randomGif=" " },
         new namesList { name = "Hana", randomGif=" " },
         new namesList { name = "Afnan", randomGif=" " }

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

