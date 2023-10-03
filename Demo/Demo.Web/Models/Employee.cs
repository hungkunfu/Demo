namespace Demo.Web.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "Tên")]
        [StringLength(maximumLength:100,MinimumLength =2)]
        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string Name { get; set; }
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Điện thoại")]
        [StringLength(maximumLength: 15, MinimumLength = 10)]
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        public string Phone { get; set; }
        [Display(Name = "Địa chỉ")]
        [StringLength(maximumLength: 250, MinimumLength = 1)]
        public string? Address { get; set; }
    }
}
