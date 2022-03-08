using StreamsTalk.Application.Interfaces;
using StreamsTalk.Application.ViewModels;
using StreamsTalk.Domain.Entities;
using StreamsTalk.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StreamsTalk.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public async Task Delete(string id)
        {
            try
            {
                await _repo.Delete(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Employee> Get(string id)
        {
            return await _repo.Get(id);
        }

        public Task<List<Employee>> GetAll()
        {
            return _repo.GetAll();
        }

        public async Task Insert(EmployeeVm entity)
        {
            try
            {
                var model = new Employee();
                FillModel(model, entity);

                await _repo.Insert(model);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Update(string id, EmployeeVm entity)
        {
            try
            {
                var model = await _repo.Get(id);
                FillModel(model, entity);

                await _repo.Update(id,model);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FillModel(Employee model, EmployeeVm entity)
        {
            model.FirstName = entity.FirstName;
            model.LastName = entity.LastName;
            model.MiddleName = entity.MiddleName;
            model.LastModifiedTime = DateTime.Now;
        }

        public async Task<bool> EmployeeExists(string id)
        {
            return await _repo.IsExists(id);
        }

       
    }
}
