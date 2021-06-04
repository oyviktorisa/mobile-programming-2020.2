using System.Threading.Tasks;
using Employee.DataAccess.EntityFramework;

namespace Employee.DataAccess
{
    public interface IEmployeeRepository
    {
        Task<Employees> Add(Employees employee);
    }
}