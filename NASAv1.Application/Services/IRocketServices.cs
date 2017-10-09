using NASAv1.Domain.Entities;
using NASAv1.Domain.Interfaces;

namespace NASAv1.Application.Services
{
    public interface IRocketServices : IRepository<Rocket>
    {
        int Create(Rocket rocket);
        bool Update(Rocket rocket);
        int Delete(int id);
        int GetById(int id);
        int GetAll();
        bool LaunchRocket(string Direction);
    }
}
