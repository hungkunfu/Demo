using Demo.Web.Models;
using Demo.Web.Data;
using System.Linq.Dynamic.Core;

namespace Demo.Web.Service
{
    public interface IEmployeeService
    {
        Task<List<EmployeeVm>> GetFilters(FilterRequest request);
        Task<List<EmployeeVm>> GetAll();
        Task<EmployeeVm> GetById(int id);
    }

    public class EmployeeService : BaseService, IEmployeeService
    {
        private readonly ApplicationDbContext _context;
        public EmployeeService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<EmployeeVm>> GetAll()
        {
            var query = await (from ep in _context.Employees
                               join eld in _context.EmployeeDetails on ep.Id equals eld.EmployeeId
                               orderby ep.Name
                               select new EmployeeVm()
                               {
                                   Name = ep.Name,
                                   Address = ep.Address,
                                   Email = ep.Email,
                                   Interests = eld.Interests,
                                   Marriagestatus = eld.Marriagestatus,
                                   Phone = ep.Phone,
                                   Description = ep.Phone

                               }).ToListAsync();
            return query;
        }

        public async Task<EmployeeVm> GetById(int id)
        {
            var query = await (from ep in _context.Employees
                               join eld in _context.EmployeeDetails on ep.Id equals eld.EmployeeId into epld
                               from eld in epld.DefaultIfEmpty()
                               where ep.Id == id
                               orderby ep.Name descending
                               select new EmployeeVm()
                               {
                                   Id = ep.Id,
                                   Name = ep.Name,
                                   Address = ep.Address,
                                   Email = ep.Email,
                                   Interests = eld.Interests,
                                   Marriagestatus = eld.Marriagestatus,
                                   Phone = ep.Phone,
                                   Description = ep.Phone
                               }).FirstOrDefaultAsync();
            return query;

        }

        public async Task<List<EmployeeVm>> GetFilters(FilterRequest request)
        {
            var query = await (from ep in _context.Employees
                               join eld in _context.EmployeeDetails on ep.Id equals eld.EmployeeId into epld
                               from eld in epld.DefaultIfEmpty()
                               where ep.Name == request.Keyword.Trim() || ep.Email == request.Keyword.Trim() || ep.Phone == request.Keyword.Trim()
                               || ep.Address == request.Keyword.Trim()
                               orderby ep.Name
                               select new EmployeeVm()
                               {
                                   Id = ep.Id,
                                   Name = ep.Name,
                                   Address = ep.Address,
                                   Email = ep.Email,
                                   Interests = eld.Interests,
                                   Marriagestatus = eld.Marriagestatus,
                                   Phone = ep.Phone,
                                   Description = ep.Phone
                               }).ToListAsync();
            return query;
        }
    }

}
