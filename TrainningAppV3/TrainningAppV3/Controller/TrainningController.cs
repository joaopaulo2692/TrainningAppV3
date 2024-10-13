using FluentResults;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainningApp.Core.DTO;
using TrainningApp.Core.ServicesInterface;

namespace TrainningAppV3.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class TrainningController : ControllerBase
    {
        public readonly ITrainningService _trainningService;
        private readonly AuthenticationStateProvider _auth;

        public TrainningController(ITrainningService trainningService, AuthenticationStateProvider auth)
        {
            _trainningService = trainningService;
            _auth = auth;
        }

        [HttpPost]
        public async Task<IActionResult> SaveAsync(TrainningVO model)
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

                Result response = await _trainningService.SaveAsync(model, idUser);
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

        [HttpPost]
        public async Task<IActionResult> DeleteAsync(int model)
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

                Result response = await _trainningService.RemoveAsync(model, idUser);
                if (response.IsFailed)
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

        [HttpGet]
        public async Task<IActionResult> GetAllAdmAsync()
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

                List<TrainningVO> response = await _trainningService.GetAllAsync(idUser);
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
        public async Task<IActionResult> GetAllByPersonalAsync()
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

                List<TrainningVO> response = await _trainningService.GetAllByIdPersonalAsync(idUser);
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
        public async Task<IActionResult> GetByIdAsync(int trainningId)
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

                TrainningVO response = await _trainningService.GetByIdAsync(trainningId, idUser);
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
