using ProSync.Domain.Repositories;
using ProSync.Presentation.Models.Project;

namespace ProSync.Application.Services
{
    public class ProjectService
    {
        private readonly IProjectRepository _repository;
        public ProjectService(IProjectRepository _repository)
        {
            this._repository = _repository;
        }
        public void Create(ProjectVm projectVm)
        {

        }

        public void Update(ProjectVm projectVm)
        {

        }
    }
}
