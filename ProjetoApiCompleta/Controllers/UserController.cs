using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPires.Controllers
{
    [ApiControler]
    [route("api/users")]
    public class UserController : ControllerBase
    {
      private readonly IMapper _mapper;
      private readonly IUserService _userservice;
      public UserController(IuserService userservice, IMapper mapper){
      _userserivce = userserivce;
      _mapper = mapper;
      }
      
      [HttpPost("RegistrarUsuario')
      public async Task<ActionResult> Cadastrar([FromBody] CreateUsuarioDTO usuario){
      var usuarioAdd = _mapper.map<Usuario>(usuario);
      await _userservice.CadastrarUsuario(usuario);
      return created("Usuario cadastrado", usuarioAdd);
      }
      
      [HttpPost("Login")]
      public ActionResult<string> Login([FromBody] UsuarioLoginDTO usuarioLogin)
      {
         try{
          return _userservice.GenerateToken(usuarioLogin);
         }catch(Exception e)
         {
           Return StatusCode(400, e.message);
         }
         
   
      }
      
      }
    }
}
