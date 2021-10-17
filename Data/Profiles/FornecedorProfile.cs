using AutoMapper;
using Business.Model;
using Data.DTO_S.EnderecoDTO;
using Data.DTO_S.FornecedorDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Profiles
{
     public class FornecedorProfile : Profile
    {
        public FornecedorProfile() : base()
        {
            CreateMap<CreateFornecedorDTO, Fornecedor>();
            CreateMap<Fornecedor, ReadFornecedorDTO>();
            CreateMap<List<Fornecedor>, List<ReadFornecedorDTO>>();
            CreateMap<List<ReadFornecedorDTO>, List<Fornecedor>>();
            CreateMap<List<Fornecedor>, List<ReadFornecedorDTO>>();
            CreateMap<EnderecoDTO, Endereco>();


        }
    }
}
