using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.DTO.TrainningDay;
using TrainningApp.Core.Entities;

namespace TrainningApp.Core.Profiles
{
    public class TrainningDayProfile : Profile
    {
        public TrainningDayProfile()
        {
            CreateMap<TrainningDayVO, TrainningDay>()
                .ForMember(x => x.TrainningExercises.Select(x => x.Id), x => x.MapFrom(x => x.TrainningExercisesId))
                .ReverseMap();

            CreateMap<TrainningDay, TrainningDayVO>()
                .ForMember(x => x.TrainningExercisesId , x => x.MapFrom(x => x.TrainningExercises.Select(x => x.Id)))
                .ReverseMap();
        }
    }
}
