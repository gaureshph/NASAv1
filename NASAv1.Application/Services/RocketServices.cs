using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NASAv1.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace NASAv1.Application.Services
{
    public class RocketServices : IRocketServices
    {
        public void Add(Rocket entity)
        {
            throw new NotImplementedException();
        }

        public Rocket Find(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Rocket> Get(Expression<Func<IList<Rocket>, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Rocket> GetAll()
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
    }
}
