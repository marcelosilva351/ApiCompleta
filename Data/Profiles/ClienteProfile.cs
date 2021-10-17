using AutoMapper;
using Business.Model;
using Data.DTO_S.ClienteDTO_S;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDTO, Cliente>();
            CreateMap<Cliente, ReadClienteDTO>();
        }
    }
}
