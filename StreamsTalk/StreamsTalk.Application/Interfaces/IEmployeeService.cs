using StreamsTalk.Application.ViewModels;
using StreamsTalk.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StreamsTalk.Application.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAll();

        Task<Employee> Get(string id);

        Task Insert(EmployeeVm entity);

        Task Update(string id, EmployeeVm entity);

        Task Delete(string id);
        Task<bool> EmployeeExists(string id);
    }
}
