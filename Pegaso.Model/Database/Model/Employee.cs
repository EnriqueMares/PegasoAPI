using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Pegaso.Model.Database.Model
{
    [Table(nameof(Employee), Schema = "Business")]
    public class Employee
    {
        [Required]
        public int CompanyId { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime DeleteOn { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        public string Fax { get; set; }
        public string Name { get; set; }
        public DateTime LastLogin { get; set; }
        
        [Required]
        public string Password { get; set; }
        
        [Required]
        [Key]
        public int PortalId { get; set; }
        
        [Required]
        public int RoleId { get; set; }

        [Required]
        public int StatusId { get; set; }
        
        public string Telephone { get; set; }
        public DateTime UpdateOn { get; set; }

        [Required]
        public string Username { get; set; }
    }
}
