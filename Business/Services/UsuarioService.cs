using Business.Interfaces;
using Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UsuarioService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UsuarioService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task CadastrarUsuario(Usuario usuario)
        {
           await _userRepository.Create(usuario);
        }

        public string Login(Usuario usuario)
        {
            return _userRepository.GerarToken(usuario);

        }
    }
}
