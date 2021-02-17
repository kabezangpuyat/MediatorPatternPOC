﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MNV.Commands.User;
using MNV.Domain.Models.Queries;
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

        [HttpGet("get-all"), AllowAnonymous]
        public async Task<IActionResult> GetAll(int? page = null, int? pagesize = null)
        {
            return await ExecuteQuery(new GetAllUser.Query { Paging = new PagingModel { Page = page ?? 0, PageSize = pagesize ?? 0 } })
                .ConfigureAwait(false);
        }

        [HttpGet("get-by-id/{id}"), AllowAnonymous]
        public async Task<IActionResult> GetById (long id)
        {
            return await ExecuteQuery(new GetUserById.Query(id))
                .ConfigureAwait(false);
        }

        [HttpPost("create"), AllowAnonymous]
        public async Task<IActionResult> Create(UserViewModel model)
        {
            return await ExecuteCommand(new CreateUser.Command(model))
                .ConfigureAwait(false);
        }
        #endregion
    }
}
