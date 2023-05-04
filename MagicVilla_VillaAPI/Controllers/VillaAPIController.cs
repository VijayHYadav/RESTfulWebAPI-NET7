using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    //[Route("api/[controller]")] If we write 'controller', that will automatically apply VillaAPI to the route right here.
    [Route("api/villaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.villaList;
        }
    }
}


/*
 * In order to make that a controller,it must end with the word controller. 
 * In order to make this a controller class, it has to derive from the class controller base.
 * 
 * If you are creating a REST API, make your Controller class derive from ControllerBase and not Controller class. Controller derives from ControllerBase and adds support for MVC views. 
 */