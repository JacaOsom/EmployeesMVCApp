using System.ComponentModel.DataAnnotations;

namespace EmployeesMVCApp.Models
{
    public class EmployeeModel
    {
        //[Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public DateTime DateOfHired { get; set; }
        public string JobPosition { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get;set; }
        public string City { get;set; }
        public string ZIPCode { get;set; }
        public string Street { get;set; }
        public string BuildingNumber { get;set; }
        public string ApartmentNumber { get;set; }

    }
}
