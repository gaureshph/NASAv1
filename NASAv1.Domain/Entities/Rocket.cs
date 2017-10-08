using NASAv1.Domain.Interfaces;
using System;

namespace NASAv1.Domain.Entities
{
    public class Rocket: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LaunchDate { get; set; }
    }
}
