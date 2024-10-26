using FluentResults;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainningApp.Core.DTO;
using TrainningApp.Core.DTO.Exercise;
using TrainningApp.Core.ServicesInterface;
using TrainningApp.Infrastructure.Services;

namespace TrainningAppV3.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly AuthenticationStateProvider _auth;
        private readonly IExerciseService _exerciseService;

        public ExerciseController(AuthenticationStateProvider auth, IExerciseService exerciseService)
        {
            _auth = auth;
            _exerciseService = exerciseService;
        }

        [HttpPost]
        public async Task<IActionResult> SaveAsync([FromBody]ExerciseVO model)
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

                Result response = await _exerciseService.SaveAsync(model, idUser);
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
        public async Task<IActionResult> GetByIdAsync(int exerciseId)
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

                ExerciseVO response = await _exerciseService.FindByIdAsync(exerciseId, idUser);
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
    }
}
