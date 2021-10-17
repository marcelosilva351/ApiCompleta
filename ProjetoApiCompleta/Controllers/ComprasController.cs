using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPires.Controllers
{
    [Authorize(Role="Gerente)]
    [ApiController]
    [Route("api/compras)]
    public class ComprasController : ControllerBase
    {
    }
}
