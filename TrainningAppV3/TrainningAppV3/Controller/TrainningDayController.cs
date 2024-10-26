using FluentResults;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainningApp.Core.DTO.TrainningDay;
using TrainningApp.Core.ServicesInterface;

namespace TrainningAppV3.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class TrainningDayController : ControllerBase
    {
        private readonly AuthenticationStateProvider _auth;
        private readonly ITrainningDayService _trainningDayService;

        public TrainningDayController(AuthenticationStateProvider auth, ITrainningDayService trainningDayService)
        {
            _auth = auth;
            _trainningDayService = trainningDayService;
        }

        [HttpPost]
        public async Task<IActionResult> SaveAsync(TrainningDayVO model)
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
                Result response = await _trainningDayService.SaveAsync(model, idUser);

                if (response.IsFailed)
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
                if (response.IsSuccess && model.Id != 0)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }

                return StatusCode(StatusCodes.Status201Created);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int trainningDayId)
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
                TrainningDayVO response = await _trainningDayService.FindByIdAsync(trainningDayId, idUser);

                if (response == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, response);

                }

                return StatusCode(StatusCodes.Status200OK, response);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
           

        }


    }
}
