using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskSystem
{
    public interface IEmployeeManager:IDomainService
    {
        IEnumerable<Employee> GetAllList();
        Employee GetEmployeeByID(int id);
        Task<Employee> Create(Employee output);
        void Update(Employee entity);
        void Delete(int id);
      //  Task Create(object output);
    }
}
