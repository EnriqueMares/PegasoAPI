using AutoMapper;
using Pegaso.Common.Requests;
using Pegaso.Common.Responses;
using Pegaso.Model.Database.Model;

namespace Pegaso.Services.AutoMapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMaps();
        }

        public void CreateMaps()
        {
            CreateMap<Employee, EmployeeResponse>();
            CreateMap<Employee, EmployeeRequest>();
        }
    }
}
