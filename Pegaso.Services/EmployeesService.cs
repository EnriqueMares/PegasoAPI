using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pegaso.Common.Contracts;
using Pegaso.Common.Requests;
using Pegaso.Common.Responses;
using Pegaso.Model.Database;
using Pegaso.Model.Database.Model;

namespace Pegaso.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly PegasoDbContext _context;
        private readonly IMapper _mapper;

        public EmployeesService()
        {

        }

        public EmployeesService(PegasoDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<EmployeeResponse>> ObtenerEmpleados()
        {
            var empleados = await _context.Employee
                .AsNoTracking()
               .Select(x => _mapper.Map<EmployeeResponse>(x))
               .ToListAsync();

            return empleados;
        }

        public async Task<EmployeeResponse> ObtenerEmpleadoPorId(int id)
        {
            var empleado = await _context.Employee
                .AsNoTracking()
                .Where(e => e.PortalId == id)
               .Select(x => _mapper.Map<EmployeeResponse>(x))
               .FirstOrDefaultAsync();

            return empleado;
        }

        public async Task<bool> ActualizarEmpleado(EmployeeRequest employee)
        {
            var empleado = await _context.Employee
                .AsNoTracking()
                .Where(e => e.PortalId == employee.PortalId)
                .Select(x => _mapper.Map<EmployeeResponse>(x))
                .FirstOrDefaultAsync();

            if (empleado != null)
            {
                empleado.CompanyId = employee.PortalId;
                empleado.Email = employee.Email;
                empleado.Fax = employee.Fax;
                empleado.Name = employee.Name;
                empleado.Password = employee.Password;
                empleado.RoleId = employee.RoleId;
                empleado.StatusId = employee.StatusId;
                empleado.Telephone = employee.Telephone;
                empleado.UpdateOn = DateTime.Now;
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> EliminarEmpleado(int id)
        {
            var empleado = await _context.Employee
                .AsNoTracking()
                .Where(e => e.PortalId == id)
                .Select(x => _mapper.Map<EmployeeResponse>(x))
                .FirstOrDefaultAsync();

            if (empleado != null)
            {
                empleado.DeleteOn = DateTime.Now;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public async Task<EmployeeRequest> InsertarEmpleado(EmployeeRequest employee)
        {
            await _context.AddAsync(employee);
            return employee;
        }
    }
}
