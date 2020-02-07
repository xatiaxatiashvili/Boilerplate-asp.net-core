using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskSystem.Models
{
    //public class EmployeeManager:DomainService,IEmployeeManager
    //{
        //private readonly IRepository<Employee> _repositoryEmployee;
        //public EmployeeManager(IRepository<Employee> repositoryEmployee)
        //{
        //    _repositoryEmployee = repositoryEmployee;
        //}

        //public async Task<Employee> Create(Employee entity)
        //{
        //    var employee = _repositoryEmployee.FirstOrDefault(x => x.Id == entity.Id);
        //    if(employee!=null)
        //    {
        //        throw new UserFriendlyException("Already Exist!");
        //    }
        //    else
        //    {
        //        return await _repositoryEmployee.InsertAsync(entity);
        //    }
            
        //}

        //public void Delete(Guid id)
        //{
        //    var employee = _repositoryEmployee.FirstOrDefault(x => x.Id == id);
        //    if(employee==null)
        //    {
        //        throw new UserFriendlyException("No Data Found!");
        //    }
        //    else
        //    {
        //        _repositoryEmployee.Delete(employee);
        //    }
           
        //}

        //public IEnumerable<Employee> GetAllList()
        //{
        //    return _repositoryEmployee.GetAllIncluding(x => x.Name);
        //}

        //public Employee GetEmployeeByID(int id)
        //{
        //    return _repositoryEmployee.Get(id);
        //}

        //public void Update(Employee entity)
        //{
        //    _repositoryEmployee.Update(entity);
        //}
    //}
}
