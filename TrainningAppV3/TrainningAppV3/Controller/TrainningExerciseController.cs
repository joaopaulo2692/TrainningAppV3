using FluentResults;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainningApp.Core.DTO.TrainningExercise;
using TrainningApp.Core.ServicesInterface;
using TrainningApp.Infrastructure.Services;

namespace TrainningAppV3.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class TrainningExerciseController : ControllerBase
    {
        public readonly ITrainningExerciseService _trainningExerciseService;
        private readonly AuthenticationStateProvider _auth;

        public TrainningExerciseController(ITrainningExerciseService trainningExerciseService, AuthenticationStateProvider auth)
        {
            _trainningExerciseService = trainningExerciseService;
            _auth = auth;
        }

        [HttpPost]
        public async Task<IActionResult> SaveAsync([FromBody]TrainningExerciseVO trainningExerciseVO)
        {
            try
            {
                var authenticationState = await _auth.GetAuthenticationStateAsync();
                var user = authenticationState.User;
                bool isAuth = user.Identity.IsAuthenticated;
                var idUser = user.Claims.Select(x => x.Value).FirstOrDefault();
                if (!isAuth)
                {
                    return StatusCode(StatusCodes.Status401Unauthorized);
                }
                if (isAuth)
                {
                    var name = authenticationState.User.Claims.FirstOrDefault().Value;
                }
                Result response = await _trainningExerciseService.SaveAsync(trainningExerciseVO, idUser);

                if (response.IsFailed)
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetAllByTrainningDayAsync(int trainningDayId)
        {
            try
            {
                var authenticationState = await _auth.GetAuthenticationStateAsync();
                var user = authenticationState.User;
                bool isAuth = user.Identity.IsAuthenticated;
                var idUser = user.Claims.Select(x => x.Value).FirstOrDefault();
                if (!isAuth)
                {
                    return StatusCode(StatusCodes.Status401Unauthorized);
                }
                if (isAuth)
                {
                    var name = authenticationState.User.Claims.FirstOrDefault().Value;
                }
                List<TrainningExerciseVO> response = await _trainningExerciseService.GetAllByTrainningDay(idUser, trainningDayId);

                if (response == null)
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
                return StatusCode(StatusCodes.Status200OK, response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetByIdAsync(int trainningExerciseId)
        {
            try
            {
                var authenticationState = await _auth.GetAuthenticationStateAsync();
                var user = authenticationState.User;
                bool isAuth = user.Identity.IsAuthenticated;
                var idUser = user.Claims.Select(x => x.Value).FirstOrDefault();
                if (!isAuth)
                {
                    return StatusCode(StatusCodes.Status401Unauthorized);
                }
                if (isAuth)
                {
                    var name = authenticationState.User.Claims.FirstOrDefault().Value;
                }
                TrainningExerciseVO response = await _trainningExerciseService.GetByIdAsync(idUser, trainningExerciseId);

                if (response == null)
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
                return StatusCode(StatusCodes.Status200OK, response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteAsync(int trainningDayId)
        {
            try
            {
                var authenticationState = await _auth.GetAuthenticationStateAsync();
                var user = authenticationState.User;
                bool isAuth = user.Identity.IsAuthenticated;
                var idUser = user.Claims.Select(x => x.Value).FirstOrDefault();
                if (!isAuth)
                {
                    return StatusCode(StatusCodes.Status401Unauthorized);
                }
                if (isAuth)
                {
                    var name = authenticationState.User.Claims.FirstOrDefault().Value;
                }
                Result response = await _trainningExerciseService.RemoveAsync(trainningDayId, idUser);

                if (response == null)
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
