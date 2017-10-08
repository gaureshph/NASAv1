using NASAv1.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace NASAv1.Domain.Entities
{
    public class Rocket: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LaunchDate { get; set; }
        public IList<Satellite> Satellites { get; set; }
    }
}
