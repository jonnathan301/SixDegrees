using System;
using System.Threading.Tasks;
using Business.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioBusiness _usuariobusiness;

        public UsuarioController(IUsuarioBusiness UsuarioBusiness)
        {
            _usuariobusiness = UsuarioBusiness;
        }      

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList()
        {
            try
            {
                return Ok(await _usuariobusiness.GetList());
            }
            catch (Exception Exception)
            {
                return BadRequest(Exception);
            }
        }
    }
}
