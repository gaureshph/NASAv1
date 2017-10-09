using System;
using NASAv1.Domain.Entities;
using NASAv1.Domain.Interfaces;

namespace NASAv1.Application.Services
{
    public class SatelliteServices : ISatelliteServices
    {
        private IRepository<Satellite> _repository;

        public SatelliteServices(IRepository<Satellite> repository)
        {
            _repository = repository;
        }

        public int Create(Satellite satellite)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int GetAll()
        {
            throw new NotImplementedException();
        }

        public int GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Satellite satellite)
        {
            throw new NotImplementedException();
        }
    }
}
