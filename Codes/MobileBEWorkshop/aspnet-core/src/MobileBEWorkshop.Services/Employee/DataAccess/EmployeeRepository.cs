using System;
using System.Threading.Tasks;
using Employee.DataAccess.EntityFramework;

namespace Employee.DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly MobileBEWorkshopEmployeeContext dbContext;

        public EmployeeRepository(MobileBEWorkshopEmployeeContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<Employees> Add(Employees employee)
        {
            dbContext.Employees.Add(employee);
            await dbContext.SaveChangesAsync();
            return employee;
        }
    }
}