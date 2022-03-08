using StreamsTalk.Domain.Entities;
using StreamsTalk.Domain.Interfaces;
using StreamsTalk.Infra.Data.Context;

namespace StreamsTalk.Infra.Data.Repositories
{
    public class  EmployeeRepository: Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(StreamsTalkDbContext dbContext)
          : base(dbContext)
        {

        }
    }
}
