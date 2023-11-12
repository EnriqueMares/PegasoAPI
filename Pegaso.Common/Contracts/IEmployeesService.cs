using Microsoft.AspNetCore.Mvc;
using Pegaso.Common.Requests;
using Pegaso.Common.Responses;

namespace Pegaso.Common.Contracts
{
    public interface IEmployeesService
    {
        Task<List<EmployeeResponse>> ObtenerEmpleados();
        Task<EmployeeResponse> ObtenerEmpleadoPorId(int id);
        Task<EmployeeRequest> InsertarEmpleado(EmployeeRequest employee);
        Task<bool> ActualizarEmpleado(EmployeeRequest employee);
        Task<bool> EliminarEmpleado(int id);
    }
}
