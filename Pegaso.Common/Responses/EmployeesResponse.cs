﻿namespace Pegaso.Common.Responses
{
    public class EmployeesResponse
    {
        public List<EmployeeResponse> Employees { get; set; }
    }

    public class EmployeeResponse
    {
        public int CompanyId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DeleteOn { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Name { get; set; }
        public DateTime LastLogin { get; set; }
        public string Password { get; set; }
        public int PortalId { get; set; }
        public int RoleId { get; set; }
        public int StatusId { get; set; }
        public string Telephone { get; set; }
        public DateTime UpdateOn { get; set; }
        public string Username { get; set; }
    }
}
