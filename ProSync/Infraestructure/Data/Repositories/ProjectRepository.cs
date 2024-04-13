using ProSync.Domain.Entities;
using ProSync.Domain.Repositories;

namespace ProSync.Infraestructure.Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public void Create(Project project)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllByClient(Guid clientId)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllByProfessional(Guid professionalId)
        {
            throw new NotImplementedException();
        }

        public Project? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
