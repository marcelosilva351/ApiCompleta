using AutoMapper;
using Business.Model;
using Data.DTO_S.CompraDTO_S;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Profiles
{
    public class CompraProfile : Profile
    {
        public CompraProfile()
        {
            CreateMap<CreateCompraDTO, Compra>();
        }
    }
}
