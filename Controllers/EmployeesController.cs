using Microsoft.AspNetCore.Mvc;
using Pegaso.Common.Contracts;
using Pegaso.Common.Extensions;
using Pegaso.Common.Requests;
using Pegaso.Common.Responses;
using Pegaso.Model.Database.Model;
using System.Net;

namespace Pegaso.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _employeesService;

        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerEmpleados()
        {
            var result = await _employeesService.ObtenerEmpleados();
            return new StandardResponse<List<EmployeeResponse>>(HttpStatusCode.OK, result).ToActionResult();
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerEmpleadoPorId(int id)
        {
            var result = await _employeesService.ObtenerEmpleadoPorId(id);
            return new StandardResponse<EmployeeResponse>(HttpStatusCode.OK, result).ToActionResult();
        }

        [HttpPost]
        public async Task<IActionResult> InsertarEmpleado(EmployeeRequest employee)
        {
            var result = await _employeesService.InsertarEmpleado(employee);
            return new StandardResponse<EmployeeRequest>(HttpStatusCode.OK, result).ToActionResult();
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarEmpleado(EmployeeRequest employee)
        {
            var result = await _employeesService.ActualizarEmpleado(employee);
            return new StandardResponse<bool>(HttpStatusCode.OK, result).ToActionResult();
        }

        [HttpDelete]
        public async Task<IActionResult> EliminarEmpleado(int id)
        {
            var result = await _employeesService.EliminarEmpleado(id);
            return new StandardResponse<bool>(HttpStatusCode.OK, result).ToActionResult();
        }
    }
}
