using Xunit;
using Pegaso.Services;
using Pegaso.Common.Requests;

namespace Pegaso.Tests
{
    public class EmployeeTest
    {
        EmployeesService service;
        EmployeeRequest employeeRequest=new EmployeeRequest();
        int idCorrecto;
        int idIncorrecto;
        public EmployeeTest()
        {
            service = new EmployeesService();

            employeeRequest.CompanyId = 1;
            employeeRequest.CreatedOn = DateTime.Now;
            employeeRequest.DeleteOn = DateTime.Now;
            employeeRequest.UpdateOn = DateTime.Now;
            employeeRequest.Email = "test1@test.test.tmp";
            employeeRequest.Fax = "000.000.000";
            employeeRequest.Name = "test1";
            employeeRequest.LastLogin = DateTime.Now;
            employeeRequest.Password = "test";
            employeeRequest.PortalId = 1;
            employeeRequest.RoleId = 1;
            employeeRequest.StatusId = 1;
            employeeRequest.Telephone = "000.000.0000";
            employeeRequest.Username = "test1";

            idCorrecto = 1;
            idIncorrecto = 2;
        }
        
        [Fact]
        public void Insertar_Correcto()
        {
            var result = service.InsertarEmpleado(employeeRequest);
            Assert.NotEmpty((System.Collections.IEnumerable)result.Result);
        }

        [Fact]
        public void Buscar_Correcto()
        {
            var result = service.ObtenerEmpleadoPorId(idCorrecto);
            Assert.True(result.Result != null);
        }

        [Fact]
        public void Buscar_Incorrecto()
        {
            var result = service.ObtenerEmpleadoPorId(idIncorrecto);
            Assert.True(result.Result == null);
        }

        [Fact]
        public void Eliminar_Correcto()
        {
            var result = service.EliminarEmpleado(idCorrecto);
            Assert.True(result.Result);
        }

        [Fact]
        public void Eliminar_Incorrecto()
        {
            var result = service.EliminarEmpleado(idIncorrecto);
            Assert.True(result.Result);
        }

        [Fact]
        public void Actualizar_Correcto()
        {
            employeeRequest.PortalId = idCorrecto;
            var result = service.ActualizarEmpleado(employeeRequest);
            Assert.True(result.Result);
        }

        [Fact]
        public void Actualizar_Incorrecto()
        {
            employeeRequest.PortalId = idIncorrecto;
            var result = service.ActualizarEmpleado(employeeRequest);
            Assert.False(result.Result);
        }
    }
}