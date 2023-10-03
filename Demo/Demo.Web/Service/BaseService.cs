using Demo.Data.EF;
using Microsoft.EntityFrameworkCore;

namespace Demo.Web.Service
{
    public class BaseService
    {
        private readonly ApplicationDbContext _context;
        public BaseService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
