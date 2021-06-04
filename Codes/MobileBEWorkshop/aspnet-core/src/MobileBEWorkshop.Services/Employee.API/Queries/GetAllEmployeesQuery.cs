using MediatR;
using System.Collections.Generic;
using System.Net;
using Employee.API.Queries.EmployeeDraftDTO;

namespace Employee.API.Queries
{
    public class GetAllEmployeesQuery : IRequest<List<EmployeeDTO>>
    {
        
    }
}