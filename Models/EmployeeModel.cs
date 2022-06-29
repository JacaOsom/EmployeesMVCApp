using System.ComponentModel.DataAnnotations;

namespace EmployeesMVCApp.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "The field of name is required.")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "The field of lastname is required.")]
        [MaxLength(255)]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "The field of age is required.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "The field of date of hired is required.")]
        public DateTime DateOfHired { get; set; }
        [Required(ErrorMessage = "The field of job position is required.")]
        [MaxLength(50)]
        public string JobPosition { get; set; }
        [Required(ErrorMessage = "The field of phone number is required.")]
        [MaxLength(50)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "The field of email is required.")]
        [MaxLength(100)]
        public string Email { get;set; }
        [Required(ErrorMessage = "The field of city is required.")]
        [MaxLength(255)]
        public string City { get;set; }
        [Required(ErrorMessage = "The field of ZIP code is required.")]
        [MaxLength(6)]
        public string ZIPCode { get;set; }
        [Required(ErrorMessage = "The field of street is required.")]
        [MaxLength(255)]
        public string Street { get;set; }
        [Required(ErrorMessage = "The field of building number is required.")]
        [MaxLength(8)]
        public string BuildingNumber { get;set; }
        public string ApartmentNumber { get;set; }

    }
}
