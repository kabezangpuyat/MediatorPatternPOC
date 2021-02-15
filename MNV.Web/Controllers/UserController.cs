using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MNV.Commands.User;
using MNV.Domain.Models.User;
using MNV.Queries.User;

namespace MNV.Web.Controllers
{
    public class UserController : _BaseController
    {
        #region Constructor(s)
        public UserController(IMediator mediator)  : base (mediator)
        {
        }
        #endregion


        #region IActionResult(s)
        [HttpGet("values")]
        public IActionResult Index()
        {
            return  Ok(new { message = "" });
        } 

        [HttpGet("get-by-id/{id}"), AllowAnonymous]
        public async Task<IActionResult> GetById (long id)
        {
            var response = await _mediator.Send(new GetUserById.Query(id));
            return response == null ? NotFound(new { message = "Data not found." }) : Ok(response);
        }

        [HttpPost("create"), AllowAnonymous]
        public async Task<IActionResult> Create(UserViewModel model)
        {
            var response = await _mediator.Send(new CreateUser.Command(model));
            return response == null ? NotFound(new { message = "Data not found." }) : Ok(response);
        }
        #endregion
    }
}
