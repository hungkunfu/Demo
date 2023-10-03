namespace Demo.Web.Models
{
    public class EmployeeDetails
    {       
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [Display(Name = "Sở thích")]        
        public string Interests { get; set; }
        [Display(Name = "Tình trạng hôn nhân")]
        public string Marriagestatus { get; set; }
        [Display(Name = "Ghi chú")]
        public string Description { get; set; }

    }
}
