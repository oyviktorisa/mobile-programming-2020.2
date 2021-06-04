using Employee.API.Commands.DTO;
using MediatR;

namespace Employee.API.Commands
{
    public class CreateEmployeeCommand : IRequest<string>
    {
        public EmployeeDraftDTO EmployeeDraft {get;set;}
    }
}