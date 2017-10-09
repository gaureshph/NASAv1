using System;
using System.Linq;
using System.Linq.Expressions;
using NASAv1.Domain.Entities;
using NASAv1.Domain.Interfaces;

namespace NASAv1.Application.Services
{
    public class RocketServices : IRocketServices
    {
        private IRepository<Rocket> _repository;

        public RocketServices(IRepository<Rocket> repository)
        {
            _repository = repository;
        }

        public void Add(Rocket entity)
        {
            throw new NotImplementedException();
        }

        public int Create(Rocket rocket)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Rocket Find(int id)
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

        public IQueryable<Rocket> GetQueryable(Expression<Func<Rocket, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool LaunchRocket(string Direction)
        {
            throw new NotImplementedException();
        }

        public void Remove(Rocket entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Rocket rocket)
        {
            throw new NotImplementedException();
        }

        IQueryable<Rocket> IRepository<Rocket>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
