using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MNV.Web.Controllers
{
    public class UserController : _BaseController
    {
        #region Constructor(s)
        public UserController(IMediator mediator) : base(mediator)
        {
        }
        #endregion


        #region IActionResult(s)
        public IActionResult Index()
        {
            return Ok(new { message = "" });
        } 
        #endregion
    }
}
