using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskSystem.Employees
{
    public interface IEmployeeAppService:IApplicationService
    {
        IEnumerable<GetEmployeeOutput> ListAll();       
        Task Create(CreateEmployeeInput input);
        void Update(UpdateEmployeeInput input);
        void Delete(DeleteEmployeeInput input);
        GetEmployeeOutput GetEmployeeByID(GetEmployeeInput input);
    }
}
