using Abp.Application.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskSystem.Employees
{
    public class EmployeeAppService : ApplicationService, IEmployeeAppService
    {
        private readonly IEmployeeManager _employeeManager;
        public EmployeeAppService(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }
        public async Task Create(CreateEmployeeInput input)
        {
            Employee output = Mapper.Map<CreateEmployeeInput, Employee>(input);
            await _employeeManager.Create(output);
        }

        public void Delete(DeleteEmployeeInput input)
        {
            _employeeManager.Delete(input.Id);
        }

        public GetEmployeeOutput GetEmployeeByID(GetEmployeeInput input)
        {
            var getEmployee= _employeeManager.GetEmployeeByID(input.Id);
            GetEmployeeOutput output = Mapper.Map<Employee, GetEmployeeOutput>(getEmployee);
            return output;
        }

        public IEnumerable<GetEmployeeOutput> ListAll()
        {
            var getAll = _employeeManager.GetAllList().ToList();
            List<GetEmployeeOutput> output = Mapper.Map<List<Employee>, List< GetEmployeeOutput >>(getAll);
            return output;
        }

        public void Update(UpdateEmployeeInput input)
        {
            Employee output = Mapper.Map<UpdateEmployeeInput, Employee>(input);
            _employeeManager.Update(output);
        }
    }
}
