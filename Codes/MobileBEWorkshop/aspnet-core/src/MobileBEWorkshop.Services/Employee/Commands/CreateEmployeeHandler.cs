using System;
using System.Threading;
using System.Threading.Tasks;
using Employee.API.Commands;
using Employee.DataAccess;
using Employee.DataAccess.EntityFramework;
using MediatR;

namespace Employee.Commands
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, string>
    {
        private IEmployeeRepository repository;

        public CreateEmployeeHandler(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        public async Task<string> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employees obj = new Employees();
            obj.Id = Guid.NewGuid();
            obj.Name = request.EmployeeDraft.Name;
            obj.EmployeeNumber = request.EmployeeDraft.EmpNumber;
            obj.HireDate = DateTime.UtcNow;
            obj.Created = DateTime.UtcNow;
            obj.CreatedBy = "admin";
            obj.LastModified = DateTime.UtcNow;
            obj.LastModifiedBy = "admin";

            await repository.Add(obj);

            return "OK";
        }
    }
}