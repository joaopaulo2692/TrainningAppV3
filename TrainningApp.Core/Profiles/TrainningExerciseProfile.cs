using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.DTO.TrainningExercise;
using TrainningApp.Core.Entities;

namespace TrainningApp.Core.Profiles
{
    public class TrainningExerciseProfile : Profile
    {
        public TrainningExerciseProfile()
        {
            CreateMap<TrainningExercise, TrainningExerciseVO>()
                .ReverseMap();

            CreateMap<TrainningExerciseVO, TrainningExercise>()
               .ReverseMap();
        }
    }
}
