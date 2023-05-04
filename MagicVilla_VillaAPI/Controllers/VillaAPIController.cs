using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
    }
}


/*
 * In order to make that a controller,it must end with the word controller. 
 * In order to make this a controller class, it has to derive from the class controller base.
 * 
 * If you are creating a REST API, make your Controller class derive from ControllerBase and not Controller class. Controller derives from ControllerBase and adds support for MVC views. 
 */