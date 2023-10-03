using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model.Category
{
    public class CategoryVm
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public bool IsDelete { get; set; }
        public string CreateByUser { get; set; }
        public DateTime CreateOnDate { get; set; }
    }
}
