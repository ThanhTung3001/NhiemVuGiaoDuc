
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using MediatR;
using System.Collections.Generic;
using System.Collections;

namespace HueCitApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;
        private IWebHostEnvironment _hostingEnvironment;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        public BaseApiController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult SuccessResult(object data,string message,int code)
        {
            return Ok(new
            {
                data=data,
                message = message,
                code =code ,
              
            });
        }
        public IActionResult FailResult(string message, int code)
        {
            return BadRequest(new {
             
                message = message,
                code = code ,
              
            });
        }
    }
}
