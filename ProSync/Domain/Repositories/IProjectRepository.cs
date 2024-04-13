using ProSync.Domain.Entities;

namespace ProSync.Domain.Repositories
{
    public interface IProjectRepository
    {
        void Create(Project project);
        void Update(Project project);
        Project? GetById(Guid id);
        List<Project> GetAllByProfessional(Guid professionalId);
        List<Project> GetAllByClient(Guid clientId);
    }
}
