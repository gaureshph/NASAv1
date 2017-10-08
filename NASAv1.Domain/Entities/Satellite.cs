using NASAv1.Domain.Interfaces;

namespace NASAv1.Domain.Entities
{
    class Satellite: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int RocketId { get; set; }
    }
}
