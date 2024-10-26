using AutoMapper;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.Constants;
using TrainningApp.Core.DTO.Exercise;
using TrainningApp.Core.Entities;
using TrainningApp.Core.RepositoriesInterface;
using TrainningApp.Core.ServicesInterface;

namespace TrainningApp.Infrastructure.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IExerciseRepository _exerciseRepo;
        private readonly IApplicationUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IMuscleRepository _muscleRepo;
        public ExerciseService(IExerciseRepository exerciseRepo, IApplicationUserRepository userRepository, IMapper mapper, IMuscleRepository muscleRepo)
        {
            _exerciseRepo = exerciseRepo;
            _userRepository = userRepository;
            _mapper = mapper;
            _muscleRepo = muscleRepo;
        }

        public async Task<Result> DeleteAsync(int exerciseId, string idUser)
        {
            ApplicationUser user = await _userRepository.GetById(idUser);

            if (!user.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Personal) || !user.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Adm))
            {
                throw new Exception(ConstantsMessageManagement.ErrorNotAllowedManagement);
            }

            Exercise exercise = await _exerciseRepo.FindByIdAsync(exerciseId);
            if (exercise == null) throw new Exception(ConstantsMessageExercise.ErroFindById);

            Result response = await _exerciseRepo.DeleteAsync(exercise);
            return response;
        }

        public async Task<ExerciseVO> FindByIdAsync(int exerciseId, string idUser)
        {
            ApplicationUser user = await _userRepository.GetById(idUser);

            if (!user.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Personal) || !user.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Adm))
            {
                throw new Exception(ConstantsMessageManagement.ErrorNotAllowedManagement);
            }

            Exercise exercise = await _exerciseRepo.FindByIdAsync(exerciseId);
            if (exercise == null) throw new Exception(ConstantsMessageExercise.ErroFindById);

            ExerciseVO exerciseReturnVO = _mapper.Map<ExerciseVO>(exercise);

            return exerciseReturnVO;
        }

        public async Task<Result> SaveAsync(ExerciseVO model, string idUser)
        {
            ApplicationUser user = await _userRepository.GetById(idUser);
            Result response = new Result();
            if (!user.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Personal) || !user.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Adm))
            {
                throw new Exception(ConstantsMessageManagement.ErrorNotAllowedManagement);
            }

            List<Muscle> muscles = new List<Muscle>();
            foreach(string muscleName in model.Muscles)
            {
                Muscle muscle = await _muscleRepo.FindByNameAsync(muscleName);
                if(muscle == null )throw new Exception(ConstantsMessageMuscle.ErroFindByName);

                muscles.Add(muscle);
            }

            Exercise exercise = _mapper.Map<Exercise>(model);
            exercise.Muscles = muscles;

            if(model.Id == 0)
            {
                response = await _exerciseRepo.CreateAsync(exercise);
                return response;
            }

            Exercise exerciseDb = await _exerciseRepo.FindByIdAsync(model.Id);
            if (exerciseDb == null) throw new Exception(ConstantsMessageExercise.ErroFindById);

            response = await _exerciseRepo.UpdateAsync(exerciseDb);
            return response;
        }
    }
}
