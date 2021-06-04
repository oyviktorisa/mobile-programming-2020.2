using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Employee.API.Commands;
using System.Threading.Tasks;
using System;

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator mediator;
        public EmployeeController(IMediator mediator)
        {
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        /// <summary>
        /// Create new employee
        /// </summary>
        // POST api/employee/create
        [HttpPost("create")]
        public async Task<ActionResult> Post([FromBody] CreateEmployeeCommand request)
        {
            var result = await mediator.Send(request);
            return new JsonResult(result);
        }
    }
}