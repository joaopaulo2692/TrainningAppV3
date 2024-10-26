using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.DTO.Exercise;
using TrainningApp.Core.Entities;

namespace TrainningApp.Core.Profiles
{
    public class ExerciseProfile : Profile
    {
        public ExerciseProfile()
        {
            CreateMap<Exercise, ExerciseReturnVO>()
                .ForMember(x => x.Muscles, x => x.MapFrom(x => x.Muscles.Select(x => x.Name).ToList()))
                .ReverseMap();

            CreateMap<Exercise, ExerciseVO>()
                .ForMember(x => x.Muscles, x => x.MapFrom(x => x.Muscles.Select(x => x.Name).ToList()))
                .ReverseMap();

            CreateMap<ExerciseVO, Exercise>()
              .ReverseMap();

        }
    }
}
