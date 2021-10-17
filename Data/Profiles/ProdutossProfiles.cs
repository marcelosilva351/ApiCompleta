using AutoMapper;
using Business.Model;
using Data.DTO_S.ProdutoDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Profiles
{
     public class ProdutossProfiles : Profile
    {

        public ProdutossProfiles() : base()
        {
            CreateMap<CreateProdutoDTO, Produto>();
            CreateMap<Produto, ReadProdutoDTO>();
            CreateMap<List<Produto>, List<ReadProdutoDTO>>();
             
        }
    }
}
