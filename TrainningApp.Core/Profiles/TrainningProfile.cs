using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.DTO;
using TrainningApp.Core.Entities;

namespace TrainningApp.Core.Profiles
{
    public class TrainningProfile : Profile

    {
        public TrainningProfile()
        {
            CreateMap<Trainning, TrainningVO>().ReverseMap();
                
        }
    }
}
