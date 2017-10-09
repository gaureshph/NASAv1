using NASAv1.Domain.Entities;
using NASAv1.Domain.Interfaces;

namespace NASAv1.Application.Services
{
    public interface ISatelliteServices
    {
        int Create(Satellite satellite);
        bool Update(Satellite satellite);
        int Delete(int id);
        int GetById(int id);
        int GetAll();
    }
}
