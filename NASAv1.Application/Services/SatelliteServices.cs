using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public void Add(Satellite entity)
        {
            throw new NotImplementedException();
        }

        public Satellite Find(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Satellite> Get(Expression<Func<IList<Satellite>, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Satellite> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Satellite entity)
        {
            throw new NotImplementedException();
        }
    }
}
